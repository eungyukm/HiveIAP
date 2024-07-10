using System;
using RM2.Login.Structures;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.Networking;

public class WebServerException : Exception
{
    public UnityWebRequest.Result Result { get; private set; }
    public long ResponseCode { get; private set; }
    public string ErrorMessage { get; private set; }
    public ErrorResponse ErrorResponse { get; private set; }
        
    public WebServerException(HttpResponseData data) : base(data.Result.ToString())
    {
        Result = data.Result;
        ResponseCode = data.ResponseCode;
        ErrorMessage = data.ErrorMessage;

        if (string.IsNullOrWhiteSpace(data.Body))
        {
            return;
        }
        
        try
        {
            ErrorResponse = JsonConvert.DeserializeObject<ErrorResponse>(data.Body);
        }
        catch (Exception ex)
        {
            Debug.LogError(ex);
        }
    }
    
    public override string ToString()
    {
        return $"[WebRequest] Error Result: {Result}, ResponseCode: {ResponseCode}, ErrorMessage: {ErrorMessage}, ErrorResponse: {ErrorResponse?.Message ?? "Unknown"}";
    }
}