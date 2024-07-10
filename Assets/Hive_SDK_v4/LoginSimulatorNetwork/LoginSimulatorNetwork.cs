using System;
using System.Collections;
using System.Collections.Generic;
using static System.Random;
using UnityEngine;
using UnityEngine.Networking;
using hive;

public class LoginSimulatorNetwork : MonoBehaviour
{
 	static LoginSimulatorNetwork _instance = null;
	//singleton method
	static public LoginSimulatorNetwork Instance
	{
		get{
			if(_instance == null)
			{
				_instance = FindObjectOfType<LoginSimulatorNetwork>();
				if(_instance == null)
				{
					//create gameobject and add component LoginSimulatorNetwork
					GameObject obj = new GameObject();
					obj.name ="LoginSimulatorNetwork";
					_instance = obj.AddComponent<LoginSimulatorNetwork>();
                    // DontDestroyOnLoad(obj);
				}
				Debug.Assert(_instance != null,"check,create failure LoginSimulatorNetwork");
			}
			return _instance;
		}
	}

    private bool isInProgress = false;

    private string host = "https://sandbox-auth.qpyou.cn";
    private enum Path {
        gameSignIn = 0,
        gameSignInPlayer
    }

    private string[] pathString = {
        "/game/auth/signin",
        "/game/auth/signinplayer"
    };

    private enum ParameterKey {
        appId = 0,
        authorization,
        hiveCertificationKey,
        playerId,
        did,
        hiveCountry,
        gameLanguage

    }

    private string[] parameterKeyString = {
        "appid",
        "authorization",
        "hive_certification_key",
        "player_id",
        "did",
        "hive_country",
        "game_language"
    };

    private enum ResponseKey {
        resultCode = 0,
        resultMsg,
        authorization,
        data,
        seq,
        playerId,
        idpUserId,
        idpIndex,
        idpId,
        did,
    }

    private string[] responseKeyString = {
        "result_code",
        "result_msg",
        "Authorization",
        "data",
        "seq",
        "player_id",
        "idp_user_id",
        "idp_index",
        "idp_id",
        "did"
    };

    public class BaseResponse {
        public int resultCode = -1;
        public string resultMsg;
        public Dictionary<string, string> headerDictionary;
        public Dictionary<string, object> bodyDictionary;

        public BaseResponse (int resultCode, 
                            string resultMsg, 
                            Dictionary<string, string> headerDictionary, 
                            Dictionary<string, object> bodyDictionary) {
            this.resultCode = resultCode;
            this.resultMsg = resultMsg;
            this.headerDictionary = headerDictionary;
            this.bodyDictionary = bodyDictionary;
        }

        public bool isSuccess() {
            return this.resultCode == 0;
        }
    }

    public class SignInResponse: BaseResponse {
        // Header
        public string authorization = "";
        // Body
        public Int64 did = -1;
        public int seq = -1;
        public Int64 playerId = -1;
        public string idpUserId = "";
        public int idpIndex = -1;
        public string idpId = "";
        public Dictionary<string, object> dataDictionary = null;
        public SignInResponse (int resultCode, 
                                string resultMsg, 
                                Dictionary<string, string> headerDictionary, 
                                Dictionary<string, object> bodyDictionary): base(resultCode, resultMsg, headerDictionary, bodyDictionary) {     
            var networkInstance = LoginSimulatorNetwork.Instance;
            
            var keyAuthorization = networkInstance.responseKeyString[(int)ResponseKey.authorization];
            
            if (headerDictionary == null) {
                Debug.Log("SignInResponse headerDictionary is null.");
                return;
            }

            if (headerDictionary.ContainsKey(keyAuthorization)) {
                this.authorization = headerDictionary[keyAuthorization];
            } else {
                Debug.Log(string.Format("Key {0} parse failed.", keyAuthorization));
            }

            if (bodyDictionary == null) {
                Debug.Log("SignInResponse bodyDictionary is null.");
                return;
            }
            
            var keyData = networkInstance.responseKeyString[(int)ResponseKey.data];
            if (!bodyDictionary.ContainsKey(keyData)) {
                return;
            } 

            dataDictionary = bodyDictionary[keyData] as Dictionary<string, object>;

            if (dataDictionary == null) {
                Debug.Log("SignInResponse dataDictionary is null.");
                return;
            }

            var keyDid = networkInstance.responseKeyString[(int)ResponseKey.did];
            if (dataDictionary.ContainsKey(keyDid)) {
                this.did = Convert.ToInt64(dataDictionary[keyDid]);
            } else {
                Debug.Log(string.Format("Key {0} parse failed.", keyDid));
            }

            var keySeq = networkInstance.responseKeyString[(int)ResponseKey.seq];
            if (dataDictionary.ContainsKey(keySeq)) {
                this.seq = Convert.ToInt32(dataDictionary[keySeq]);
            } else {
                Debug.Log(string.Format("Key {0} parse failed.", keySeq));
            }

            var keyPlayerId = networkInstance.responseKeyString[(int)ResponseKey.playerId];
            if (dataDictionary.ContainsKey(keyPlayerId)) {
                this.playerId = Convert.ToInt64(dataDictionary[keyPlayerId]);
            } else {
                Debug.Log(string.Format("Key {0} parse failed.", keyPlayerId));
            }

            var keyIdpUserId = networkInstance.responseKeyString[(int)ResponseKey.idpUserId];
            if (dataDictionary.ContainsKey(keyIdpUserId)) {
                this.idpUserId = Convert.ToString(dataDictionary[keyIdpUserId]);
            } else {
                Debug.Log(string.Format("Key {0} parse failed.", keyIdpUserId));
            }

            var keyIdpIndex = networkInstance.responseKeyString[(int)ResponseKey.idpIndex];
            if (dataDictionary.ContainsKey(keyIdpIndex)) {
                this.idpIndex = Convert.ToInt32(dataDictionary[keyIdpIndex]);
            } else {
                Debug.Log(string.Format("Key {0} parse failed.", keyIdpIndex));
            }
        
            var keyIdpId = networkInstance.responseKeyString[(int)ResponseKey.idpId];
            if (dataDictionary.ContainsKey(keyIdpId)) {
                this.idpId = Convert.ToString(dataDictionary[keyIdpId]);
            } else {
                Debug.Log(string.Format("Key {0} parse failed.", keyIdpId));
            }
        }

        public void debug() {
            Debug.Log("resultCode = " + this.resultCode);
            Debug.Log("resultMsg = " + this.resultMsg);
            Debug.Log("authorization = " + this.authorization);
            Debug.Log("seq = " + this.seq);
            Debug.Log("playerId = " + this.playerId);
            Debug.Log("idpUserId = " + this.idpUserId);
            Debug.Log("idpIndex = " + this.idpIndex);
            Debug.Log("idpId = " + this.idpId);
            Debug.Log("did = " + this.did);
        }
    }
    
    public class SignInPlayerResponse: BaseResponse {
        public int seq = -1;
        public Int64 playerId = -1;
        public string idpUserId = "";
        public int idpIndex = -1;
        public string idpId = "";
        public List<Dictionary<string, object>> dataDictionaryList = null;

        public SignInPlayerResponse (int resultCode, 
                                    string resultMsg, 
                                    Dictionary<string, string> headerDictionary, 
                                    Dictionary<string, object> bodyDictionary): base(resultCode, resultMsg, headerDictionary, bodyDictionary) {
            var networkInstance = LoginSimulatorNetwork.Instance;

            if (bodyDictionary == null) {
                Debug.Log("SignInPlayerResponse bodyDictionary is null.");
                return;
            }
            
            var keyData = networkInstance.responseKeyString[(int)ResponseKey.data];
            if (!bodyDictionary.ContainsKey(keyData)) {
                return;
            } 

            var dataList = bodyDictionary[keyData] as List<object>;

            if (dataList == null) {
                Debug.Log("SignInPlayerResponse dataList is null.");
                return;
            }

            dataDictionaryList = new List<Dictionary<string, object>>();
            foreach (var data in dataList) {
                // var dataDictionary = data as Dictionary<string, object>;
                var dataString = MiniJSON.Json.Serialize(data);
                var dataDictionary = MiniJSON.Json.Deserialize(dataString) as Dictionary<string, object>;
                dataDictionaryList.Add(dataDictionary);
            }

            if (dataDictionaryList == null) {
                Debug.Log("SignInPlayerResponse dataDictionaryList is null.");
                return;
            }

            foreach (Dictionary<string, object> dataDictionary in dataDictionaryList) {   

                var keySeq = networkInstance.responseKeyString[(int)ResponseKey.seq];
                if (dataDictionary.ContainsKey(keySeq)) {
                    this.seq = Convert.ToInt32(dataDictionary[keySeq]);
                } else {
                    Debug.Log(string.Format("Key {0} parse failed.", keySeq));
                }

                var keyPlayerId = networkInstance.responseKeyString[(int)ResponseKey.playerId];
                if (dataDictionary.ContainsKey(keyPlayerId)) {
                    this.playerId = Convert.ToInt64(dataDictionary[keyPlayerId]);
                } else {
                    Debug.Log(string.Format("Key {0} parse failed.", keyPlayerId));
                }

                var keyIdpUserId = networkInstance.responseKeyString[(int)ResponseKey.idpUserId];
                if (dataDictionary.ContainsKey(keyIdpUserId)) {
                    this.idpUserId = Convert.ToString(dataDictionary[keyIdpUserId]);
                } else {
                    Debug.Log(string.Format("Key {0} parse failed.", keyIdpUserId));
                }

                var keyIdpIndex = networkInstance.responseKeyString[(int)ResponseKey.idpIndex];
                if (dataDictionary.ContainsKey(keyIdpIndex)) {
                    this.idpIndex = Convert.ToInt32(dataDictionary[keyIdpIndex]);
                } else {
                    Debug.Log(string.Format("Key {0} parse failed.", keyIdpIndex));
                }
            
                var keyIdpId = networkInstance.responseKeyString[(int)ResponseKey.idpId];
                if (dataDictionary.ContainsKey(keyIdpId)) {
                    this.idpId = Convert.ToString(dataDictionary[keyIdpId]);
                } else {
                    Debug.Log(string.Format("Key {0} parse failed.", keyIdpId));
                }
            }
        }

        public void debug() {
            Debug.Log("resultCode = " + this.resultCode);
            Debug.Log("resultMsg = " + this.resultMsg);
            Debug.Log("seq = " + this.seq);
            Debug.Log("playerId = " + this.playerId);
            Debug.Log("idpUserId = " + this.idpUserId);
            Debug.Log("idpIndex = " + this.idpIndex);
            Debug.Log("idpId = " + this.idpId);
        }
    }
    public delegate void RequestSignInCallback(SignInResponse signInResponse);
    public void requestSignIn(string appId, string certificationKey, RequestSignInCallback handler) {
        var url = host + pathString[(int)Path.gameSignIn];

        var body = new Dictionary<string, object> () {
            {parameterKeyString[(int)ParameterKey.appId], appId },
            {parameterKeyString[(int)ParameterKey.hiveCertificationKey], certificationKey},
            {parameterKeyString[(int)ParameterKey.did], createRandomDid()}
        };

		StartCoroutine (request(Path.gameSignIn, null, body, (baseResponse) => {
            var signInResponse = new SignInResponse(baseResponse.resultCode, 
                                                    baseResponse.resultMsg, 
                                                    baseResponse.headerDictionary, 
                                                    baseResponse.bodyDictionary);
            if (handler != null) {
                handler(signInResponse);
            }
        }));
    }

    public delegate void RequestSignInPlayerCallback(SignInPlayerResponse signInPlayerResponse);
    public void requestSignInPlayer(string appId, Int64 playerId, string authorization, RequestSignInPlayerCallback handler) {
        var url = host + pathString[(int)Path.gameSignInPlayer];

        var header = new Dictionary<string, string> () {
            {parameterKeyString[(int)ParameterKey.authorization], authorization}
        };

        var body = new Dictionary<string, object> () {
            {parameterKeyString[(int)ParameterKey.appId], appId },
            {parameterKeyString[(int)ParameterKey.playerId], playerId}
        };

		StartCoroutine (request(Path.gameSignInPlayer, header, body, (baseResponse) => {
            var signInPlayerResponse = new SignInPlayerResponse(baseResponse.resultCode, 
                                                                baseResponse.resultMsg, 
                                                                baseResponse.headerDictionary, 
                                                                baseResponse.bodyDictionary);
            if (handler != null) {
                handler(signInPlayerResponse);
            }
        }));
    }
    
    public delegate void RequestCallback(BaseResponse response);
    IEnumerator request(Path path, Dictionary<string, string> header, Dictionary<string, object> body, RequestCallback handler) {

        var url = this.host + this.pathString[(int)path];

		var jsonBodyData = MiniJSON.Json.Serialize (body);
		jsonBodyData = jsonBodyData.Replace("\"[\\\"", "[\"");
		jsonBodyData = jsonBodyData.Replace("\\\"]\"", "\"]");
        
		var byteBodyData = System.Text.Encoding.UTF8.GetBytes(jsonBodyData);

		Debug.Log ("LoginSimulatorNetwork Send URL = " + url);
        Debug.Log ("LoginSimulatorNetwork SendData = " + jsonBodyData);

        var www = new UnityWebRequest(url);
        www.method = UnityWebRequest.kHttpVerbPOST;
        www.downloadHandler = new DownloadHandlerBuffer();
        www.uploadHandler = new UploadHandlerRaw(byteBodyData);

        www.SetRequestHeader("Content-Type", "application/json");
        www.SetRequestHeader("ISCRYPT", "0");
        if (header != null) {
            foreach (var item in header) {
                www.SetRequestHeader(item.Key, item.Value);
            }
        }

        yield return www.SendWebRequest();

        if (!www.isDone || !string.IsNullOrEmpty(www.error)) {
            Debug.Log("UnityWebRequest isDone = " + www.isDone);
            Debug.Log("UnityWebRequest error = " + www.error);
            www.Dispose();
            yield break;
        }

        var headerDictionary = www.GetResponseHeaders();
        Debug.Log("headerDictionary : " + MiniJSON.Json.Serialize(headerDictionary));
        Debug.Log("www.downloadHandler.text : " + www.downloadHandler.text);

        var responseObject = MiniJSON.Json.Deserialize(www.downloadHandler.text);

        www.Dispose();

        if (responseObject == null) {
            Debug.Log("responseObject is null.");
            yield break;
        }

        var responseDictionary = responseObject as Dictionary<string, object>;

        if (responseDictionary == null) {
            Debug.Log("responseDictionary is null.");
            yield break;
        }
        
        var resultCode = -1;
        var resultMsg = "";

        var keyResultCode = this.responseKeyString[(int)ResponseKey.resultCode];
        if (responseDictionary.ContainsKey(keyResultCode)) {
            resultCode = Convert.ToInt32(responseDictionary[keyResultCode]);
        } else {
            Debug.Log(string.Format("Key {0} parse failed.", keyResultCode));
        }

        var keyResultMsg = this.responseKeyString[(int)ResponseKey.resultMsg];
        if (responseDictionary.ContainsKey(keyResultMsg)) {
            resultMsg = Convert.ToString(responseDictionary[keyResultMsg]);
        } else {
            Debug.Log(string.Format("Key {0} parse failed.", keyResultMsg));
        }

        var baseResponse = new BaseResponse(resultCode, resultMsg, headerDictionary, responseDictionary);
        if (handler != null) {
            handler(baseResponse);
        }
    }

    private Int64 createRandomDid() {
        var random = new System.Random();
        var number = random.Next(1000000000, 2000000000);
        var randomDid = (Int64)number;

        Debug.Log("created random did = " + randomDid);
        return randomDid;
    }
}
