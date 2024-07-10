using UnityEngine.Networking;

public class HttpResponseData
{
    public string Body { get; set; }
    public long ResponseCode { get; set; }
    public UnityWebRequest.Result Result { get; set; }
    public string ErrorMessage { get; set; }
    
    public HttpResponseData(string body, long responseCode, UnityWebRequest.Result result, string error)
    {
        Body = body;
        ResponseCode = responseCode;
        Result = result;
        ErrorMessage = error;
    }
    
    public override string ToString()
    {
        return $"[WebRequest] Result: {Result}, ResponseCode: {ResponseCode}, Body: {Body}, Error: {ErrorMessage}";
    }
}