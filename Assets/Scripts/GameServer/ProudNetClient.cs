using System;
using System.Collections;
using NetProtocol.Packet.C2G;
using Nettention.Proud;
using RM2.Login.Structures.World;
using UnityEngine;

public class ProudNetClient : MonoBehaviour
{
    public static ProudNetClient Inst { get; private set; }

    private static readonly System.Guid Version = new("{0x3ae33249,0xecc6,0x4980,{0xbc,0x5d,0x7b,0xa,0x99,0x9c,0x7,0x39}}");
    private readonly NetClient _client = new();

    public string serverAddress = "localhost";
    public ushort serverPort = 31200;

    public Proxy Proxy { get; private set; } = new();
    public bool IsConnected => _client.HasServerConnection();

    private void Awake()
    {
        if (Inst == null) Inst = this;

        _client.JoinServerCompleteHandler = OnJoined;
        _client.AttachProxy(Proxy);
    }

    private void OnJoined(ErrorInfo info, ByteArray replyfromserver)
    {
        if (info.errorType == ErrorType.Ok)
        {
            Debug.Log("[ProudNetClient] joined server");
            WebServerClient.WorldEnqueueQueue(WebServerContext.HashedWorldId, OnWorldEnqueueQueue, OnError);
            return;
        }

        Debug.LogError("[ProudNetClient] failed to join server");
        Debug.LogError(info.remote);
        Debug.LogError(info.errorType);
        Debug.LogError(info.detailType);
        Debug.LogError(info.comment);
        Debug.LogError(info.source);
    }

    private void Start()
    {
        Connect();
    }

    private void Update()
    {
        InfoPanel.Inst.SetGameServerConnectionState(_client.HasServerConnection());
        if (false == _client.HasServerConnection())
        {
            return;
        }

        _client.FrameMove();
    }

    public void Connect()
    {
        ErrorInfo errorInfo = new();
        if (_client.HasServerConnection())
        {
            Debug.Log("[ProudNetClient] already connected");
            _client.Disconnect();
        }

        Debug.Log("[ProudNetClient] connecting...");
        var param = new NetConnectionParam();
        param.serverIP = serverAddress;
        param.serverPort = serverPort;
        param.protocolVersion.Set(Version);

        if (_client.Connect(param, errorInfo))
        {
            Debug.Log("[ProudNetClient] connected");
            return;
        }

        Debug.LogError("[ProudNetClient] connection failed");
        Debug.LogError(errorInfo.remote);
        Debug.LogError(errorInfo.errorType);
        Debug.LogError(errorInfo.detailType);
        Debug.LogError(errorInfo.comment);
        Debug.LogError(errorInfo.source);
    }

    public void AttachStub(RmiStub stub)
    {
        _client.AttachStub(stub);
    }

    public ServerConnectionState GetState()
    {
        var state = new ServerConnectionState();
        _client.GetServerConnectionState(state);
        return state;
    }

    public void SetAddress(string value)
    {
        Debug.Log("update game server address to " + value);
        serverAddress = value;
    }

    public void SetPort(ushort value)
    {
        Debug.Log("update game server port to " + value);
        serverPort = value;
    }

    private void OnWorldEnqueueQueue(WorldQueueEnqueueResponse obj)
    {
        if (obj.Rank == 0) ConnectToGameServer();
        else StartCoroutine(WaitWorldQueue());
    }

    private IEnumerator WaitWorldQueue()
    {
        var wait = false;
        var rank = 9999;

        while (true)
        {
            yield return new WaitForSeconds(1);

            if (wait) continue;
            wait = true;
            
            WebServerClient.WorldGetQueueStatus(
                WebServerContext.HashedWorldId,
                resp => OnGetWorldQueueStatus(resp.Rank, out wait, out rank),
                ex => OnError(out wait, ex)
            );

            if (rank == 0) break;
        }
    }

    private void OnGetWorldQueueStatus(int now, out bool wait, out int cur)
    {
        wait = false;
        cur = now;

        if (cur != 0) return;
        ConnectToGameServer();
    }

    private static void OnError(out bool wait, WebServerException ex)
    {
        wait = false;
        OnError(ex);
    }

    private static void OnError(WebServerException obj)
    {
        Debug.LogError(obj);
    }

    private void ConnectToGameServer()
    {
        Proxy.AuthenticatePlayerCredentialReq(HostID.HostID_Server, RmiContext.ReliableSend, new AuthenticatePlayerCredentialReq
        {
            Token = WebServerContext.Token,
            DeviceId = SystemInfo.deviceUniqueIdentifier,
        });
    }
}