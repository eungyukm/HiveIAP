using System;
using System.Collections;
using UnityEngine.Networking;
using Newtonsoft.Json;
using RM2.Login.Structures.Account;
using RM2.Login.Structures.Player;
using RM2.Login.Structures.World;
using UnityEngine;
using SystemInfo = UnityEngine.Device.SystemInfo;

public class WebServerClient : MonoBehaviour
{
    private static WebServerClient Inst { get; set; }
    
    public static string Address { get; set; } = "https://dev.rohan2.com";


    public void Awake()
    {
        if (Inst != null)
        {
            Destroy(gameObject);
            return;
        }
        
        Inst = this;
    }

    private static string GetUrl(string path) => Address + path;

    private static IEnumerator Request<TResult>(UnityWebRequest req, Action<TResult> onSuccess, Action<WebServerException> onError) where TResult : class
    {
        Debug.Log("[WebRequest] DeviceId: " + SystemInfo.deviceUniqueIdentifier);
        Debug.Log("[WebRequest] Token: " + WebServerContext.Token);

        req.SetRequestHeader("Content-Type", "application/json");
        req.SetRequestHeader("X-Device-Id", SystemInfo.deviceUniqueIdentifier);
        req.SetRequestHeader("Authorization", "RM2-AUTH-V1 " + WebServerContext.Token);
        req.timeout = 30;

        yield return req.SendWebRequest();

        var body = req.downloadHandler?.text ?? "";
        var responseCode = req.responseCode;
        var result = req.result;
        var error = req.error;

        var data = new HttpResponseData(body, responseCode, result, error);
        Debug.Log(data.ToString());
            
        try
        {
            OnRequestCompleted(data, onSuccess, onError);
        }
        catch (Exception ex)
        {
            Debug.LogError(ex);
            onError(new WebServerException(data));
        }
    }

    private static void OnRequestCompleted<TResult>(HttpResponseData data, Action<TResult> onSuccess, Action<WebServerException> onError) where TResult : class
    {
        if (data == null)
        {
            throw new ArgumentNullException(nameof(data));
        }
        
        switch (data.Result)
        {
            case UnityWebRequest.Result.Success:
            {
                if (TryParseBody<TResult>(data, out var body))
                {
                    onSuccess(body);   
                }
                else
                {
                    onError(new WebServerException(data));
                }

                break;
            }
            case UnityWebRequest.Result.ConnectionError:
            case UnityWebRequest.Result.InProgress:
            case UnityWebRequest.Result.ProtocolError:
            case UnityWebRequest.Result.DataProcessingError:
                onError(new WebServerException(data));
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private static bool TryParseBody<TResult>(HttpResponseData data, out TResult body) where TResult : class
    {
        body = null;
        if (data.ResponseCode >= 300)
        {
            return false;
        }
        
        try
        {
            body = JsonConvert.DeserializeObject<TResult>(data.Body);
            return true;
        }
        catch (Exception ex)
        {
            Debug.LogError(ex);
            return false;
        }
    }
    
    private void Get<TResult>(string path, Action<TResult> onSuccess, Action<WebServerException> onError) where TResult : class
    {
        Debug.Log("[WebRequest] GET " + path);
        var req = UnityWebRequest.Get(GetUrl(path));
        StartCoroutine(Request(req, onSuccess, onError));
    }
    
    private void Post<TResult>(string path, Action<TResult> onSuccess, Action<WebServerException> onError) where TResult : class
    {
        Debug.Log("[WebRequest] POST " + path);
        var req = UnityWebRequest.Post(GetUrl(path), "", "application/json");
        StartCoroutine(Request(req, onSuccess, onError));
    }
    
    private void Post<TBody, TResult>(string path, TBody body, Action<TResult> onSuccess, Action<WebServerException> onError) where TBody : class where TResult : class
    {
        Debug.Log("[WebRequest] POST " + path);
        var req = UnityWebRequest.Post(GetUrl(path),JsonConvert.SerializeObject(body),"application/json");
        StartCoroutine(Request(req, onSuccess, onError));
    }
    
    private void Put<TResult>(string path, Action<TResult> onSuccess, Action<WebServerException> onError)  where TResult : class
    {
        Debug.Log("[WebRequest] PUT " + path);
        var req = UnityWebRequest.Put(GetUrl(path), "");
        StartCoroutine(Request(req, onSuccess, onError));
    }
    
    private void Put<TBody, TResult>(string path, TBody body, Action<TResult> onSuccess, Action<WebServerException> onError) where TBody : class where TResult : class
    {
        Debug.Log("[WebRequest] PUT " + path);
        var req = UnityWebRequest.Put(GetUrl(path), JsonConvert.SerializeObject(body));
        StartCoroutine(Request(req, onSuccess, onError));
    }
    
    private void Delete<TResult>(string path, Action<TResult> onSuccess, Action<WebServerException> onError) where TResult : class
    {
        Debug.Log("[WebRequest] DELETE " + path);
        var req = UnityWebRequest.Delete(GetUrl(path));
        StartCoroutine(Request(req, onSuccess, onError));
    }

    public static void AccountIssueTokenByHive(HiveLoginBody body, Action<LoginResponse> onSuccess, Action<WebServerException> onError) => Inst.Post("/api/v1/account/hive", body, onSuccess, onError);
    public static void AccountTokenRevoke(Action<TokenRevokeResponse> onSuccess, Action<WebServerException> onError) => Inst.Delete("/api/v1/account/revoke", onSuccess, onError);
    public static void AccountGetName(Action<AccountNameResponse> onSuccess, Action<WebServerException> onError) => Inst.Get("/api/v1/account/name", onSuccess, onError);
    public static void AccountSetName(AccountNameCreateBody body, Action<AccountNameCreateResponse> onSuccess, Action<WebServerException> onError) => Inst.Post("/api/v1/account/name", body, onSuccess, onError);
    
    public static void PlayerGetSimpleList(Action<SimplePlayerListResponse> onSuccess, Action<WebServerException> onError) => Inst.Get("/api/v1/player", onSuccess, onError);
    public static void PlayerGetList(string worldId, Action<PlayerListResponse> onSuccess, Action<WebServerException> onError) => Inst.Get("/api/v1/player/" + worldId, onSuccess, onError);
    public static void PlayerCreate(string worldId, PlayerCreateBody body, Action<PlayerResponse> onSuccess, Action<WebServerException> onError) => Inst.Post("/api/v1/player/" + worldId, body, onSuccess, onError);
    public static void PlayerDelete(string worldId, string playerId, Action<PlayerDeleteResponse> onSuccess, Action<WebServerException> onError) => Inst.Delete("/api/v1/player/" + worldId + "/" + playerId, onSuccess, onError);
    
    public static void WorldGetList(Action<WorldsResponse> onSuccess, Action<WebServerException> onError) => Inst.Get("/api/v1/worlds", onSuccess, onError);
    public static void WorldGetCharacterCount(Action<WorldCharacterCountResponse> onSuccess, Action<WebServerException> onError) => Inst.Get("/api/v1/worlds/character-count", onSuccess, onError);
    public static void WorldEnqueueQueue(string worldId, Action<WorldQueueEnqueueResponse> onSuccess, Action<WebServerException> onError) => Inst.Post("/api/v1/worlds/queue/" + worldId, onSuccess, onError);
    public static void WorldGetQueueStatus(string worldId, Action<WorldQueueStatusResponse> onSuccess, Action<WebServerException> onError) => Inst.Put("/api/v1/worlds/queue/" + worldId, onSuccess, onError);
    public static void WorldCancelQueue(string worldId, Action<WorldQueueCancelResponse> onSuccess, Action<WebServerException> onError) => Inst.Delete("/api/v1/worlds/queue/" + worldId, onSuccess, onError);

    public static void VerifyReceipt(VerifyReceiptBody body, Action<VerifyReceiptResponse> onSuccess, Action<WebServerException> onError) => Inst.Post("/api/v1/billing", body, onSuccess, onError);
}