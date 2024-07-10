using System.Collections;
using NetProtocol.Packet;
using Nettention.Proud;
using UnityEngine;
using Stub = NetProtocol.Packet.G2C.Stub;

public partial class ProudNetStub : MonoBehaviour
{
    public ProudNetClient client;
    private readonly Stub _stub = new();

    public void Awake()
    {
        _stub.AuthenticatePlayerCredentialRes += AuthenticatePlayerCredentialRes;
        _stub.PlayerSelectRes += PlayerSelectRes;
        _stub.PlayerEnterStageFirstRes += PlayerEnterStageFirstRes;
        _stub.PlayerEnterStageSecondRes += PlayerEnterStageSecondRes;
        _stub.PlayerEnterStageThirdRes += PlayerEnterStageThirdRes;
        _stub.PlayerEnterStageFourthRes += PlayerEnterStageFourthRes;
        _stub.PlayerEnterStageFifthRes += PlayerEnterStageFifthRes;
        _stub.PlayerGameEnterRes += PlayerGameEnterRes;
        _stub.MailListV2Res += MailListV2Res;

        client.AttachStub(_stub);
    }

    private void SendPacket<T>(T packet) where T : class, new()
    {
        StartCoroutine(SendPacketEnumerator(packet));
    }

    private IEnumerator SendPacketEnumerator(object packet)
    {
        yield return new WaitForSeconds(0.1f);
        // PacketManager.Send(client.Proxy, HostID.HostID_Server, packet);
    }
}