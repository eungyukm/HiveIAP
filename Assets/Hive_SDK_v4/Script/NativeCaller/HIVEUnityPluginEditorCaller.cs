/**
 * @file    HIVEUnityPluginEditorCaller.cs
 * @brief   Editor 용 IHIVEUnityPluginNativeCaller 구현
 * 
 * @ingroup hive
 * @author  cocororo
 * @date    2023 ~ Present.
 * @copyright Copyright © Com2uS Platform Corporation. All Right Reserved.
 */

using UnityEngine;
using System;
using System.Collections;

#if UNITY_EDITOR
namespace hive
{
	public class HIVEUnityPluginEditorCaller : IHIVEUnityPluginNativeCaller {
        HIVEUnityPlugin currentPlugin;

        public HIVEUnityPluginEditorCaller(HIVEUnityPlugin plugin) {
            currentPlugin = plugin;
        }

		public String callNativeUnity(String jsonParamString) {
			JSONObject jsonParam = new JSONObject(jsonParamString);

			JSONObject classNameParam = jsonParam["class"];
			JSONObject methodParam = jsonParam["method"];
			
			if(classNameParam.isNull || methodParam.isNull) {	
				Debug.LogError("param not found(className or method)");
				return "";
			}

			String className = classNameParam.stringValue;
			String method = methodParam.stringValue;
			String resString = "";

			if(!isSupportedFeature(className,method)) {
				//지원 불가능은 핸들러 확인해서 not supported 돌려줌
				if(jsonParam.HasField("handler")){
					callEngineNotSupported(jsonParam);
				}
			} else {
				//지원 가능한 피쳐만 구현
				if(className == "Auth") {
					resString = authExecuteNative(jsonParam);
				} else if(className == "AuthV4") {
					resString = authV4ExecuteNative(jsonParam);
				}
			}

			return resString;
		}

		public void callEngineNotSupported(JSONObject jsonParam){
			ResultAPI resultAPI = new ResultAPI(ResultAPI.ErrorCode.NOT_SUPPORTED, "Not supported function in editor");
			JSONObject resJsonParam = createResponse(resultAPI, jsonParam);
			//call engine
			currentPlugin.callEngine(resJsonParam.ToString());
		}

		public bool isSupportedFeature(string className,string method) {
			return (className == "Auth" && (
				method == "initialize" ||
				method == "getLoginType" ||
				method == "login" ||
				method == "getAccount"
			)) || (className == "AuthV4" && (
				method == "setup" ||
				method == "signIn" ||
				method == "isAutoSignIn" ||
				method == "getPlayerInfo"
			));
		}

		public JSONObject createResponse(ResultAPI resultAPI, JSONObject jsonParam) {
			JSONObject resJsonParam = new JSONObject();
			resJsonParam["class"] = jsonParam.GetField("class");
			resJsonParam["method"] = jsonParam.GetField("method");
			resJsonParam["handler"] = jsonParam.GetField("handler");
			resJsonParam["platform"] = jsonParam.GetField("platform");

			if(resultAPI != null) {
				JSONObject resultAPIJson = new JSONObject(resultAPI.toString());
				resJsonParam.AddField("resultAPI", resultAPIJson);
			}

			return resJsonParam;
		}

		public String authExecuteNative(JSONObject jsonParam) {
			String targetObject = jsonParam.GetField("targetObject").stringValue;
    		String methodName = jsonParam.GetField("method").stringValue;
			
			String resString = "";

			ResultAPI resultAPI = new ResultAPI(ResultAPI.ErrorCode.SUCCESS, "");

			if(methodName == "initialize") {
				JSONObject resJsonParam = createResponse(resultAPI, jsonParam);
				resJsonParam.AddField("authInitResult",new JSONObject());
				resJsonParam["authInitResult"].AddField("isAuthorized", "false");
				resJsonParam["authInitResult"].AddField("loginType", "GUEST");
				resJsonParam["authInitResult"].AddField("did", HIVEUnityPlugin.AuthV1LoginData.did);
				//call engine
				callEngineInEditor(resJsonParam);		// #GCPSDK4-1020
			} else if(methodName == "getLoginType") {
				JSONObject resJsonParam = createResponse(null, jsonParam);
				resJsonParam.AddField("getLoginType","GUEST"); //GUEST 고정으로 리턴해준다.
				resString = resJsonParam.ToString();
			} else if(methodName == "login") {
				JSONObject resJsonParam = createResponse(resultAPI, jsonParam);
				resJsonParam.AddField("loginType", "GUEST");

    			JSONObject currentAccount = new JSONObject();
				currentAccount.AddField("vid", HIVEUnityPlugin.AuthV1LoginData.vid);
				currentAccount.AddField("uid", "");//GUEST는 빈값
				currentAccount.AddField("did", HIVEUnityPlugin.AuthV1LoginData.did);
				currentAccount.AddField("accessToken", HIVEUnityPlugin.AuthV1LoginData.accessToken);

				resJsonParam.AddField("currentAccount", currentAccount);
				resJsonParam.AddField("usedAccount", new JSONObject()); //충돌상황이 존재하지 않음.

				//call engine
				callEngineInEditor(resJsonParam);		// #GCPSDK4-1020
			} else if(methodName == "getAccount") {
				JSONObject resJsonParam = createResponse(null, jsonParam);

				JSONObject currentAccount = new JSONObject();
				currentAccount.AddField("vid", HIVEUnityPlugin.AuthV1LoginData.vid);
				currentAccount.AddField("uid", "");//GUEST는 빈값
				currentAccount.AddField("did", HIVEUnityPlugin.AuthV1LoginData.did);
				currentAccount.AddField("accessToken", HIVEUnityPlugin.AuthV1LoginData.accessToken);

				resJsonParam.AddField("getAccount", currentAccount);

				resString = resJsonParam.ToString();
			}

			return resString;
		}

		public JSONObject GetFakePlayerInfo() {

			JSONObject ret = new JSONObject();
			ret.AddField("playerId",HIVEUnityPlugin.AuthV4LoginData.playerId);
			ret.AddField("playerName",HIVEUnityPlugin.AuthV4LoginData.playerName);
			ret.AddField("playerImageUrl",HIVEUnityPlugin.AuthV4LoginData.playerImageUrl);
			ret.AddField("playerToken",HIVEUnityPlugin.AuthV4LoginData.playerToken);
			ret.AddField("did",HIVEUnityPlugin.AuthV4LoginData.did);
			ret.AddField("providerInfoData",new JSONObject(JSONObject.Type.Array));
			ret.AddField("customProviderInfoData",new JSONObject(JSONObject.Type.Array));
			return ret;
		}

		public String authV4ExecuteNative(JSONObject jsonParam) {
			String targetObject = jsonParam.GetField("targetObject").stringValue;
    		String methodName = jsonParam.GetField("method").stringValue;
			String resString = "";

			ResultAPI resultAPI = new ResultAPI(ResultAPI.ErrorCode.SUCCESS, "");

			if(methodName == "setup") {
				JSONObject resJsonParam = createResponse(resultAPI, jsonParam);
				resJsonParam.AddField("isAutoSignIn",false);
				resJsonParam.AddField("did", HIVEUnityPlugin.AuthV4LoginData.did);
				JSONObject[] providers = {
					new JSONObject("GUEST")
				};
				resJsonParam.AddField("providerTypeList",new JSONObject(providers));
				callEngineInEditor(resJsonParam);		// #GCPSDK4-1020
			} else if(methodName == "signIn") {
				JSONObject resJsonParam = createResponse(resultAPI, jsonParam);
				resJsonParam.AddField("playerInfo",GetFakePlayerInfo());
				callEngineInEditor(resJsonParam);		// #GCPSDK4-1020
			} else if(methodName == "isAutoSignIn") {
				JSONObject resJsonParam = createResponse(null, jsonParam);
				resJsonParam.AddField("isAutoSignIn", true);
				//자동로그인 무조건 true 입니다.
				resString = resJsonParam.ToString();
			} else if(methodName == "getPlayerInfo") {
				//TODO GETPlayerInfo
				JSONObject resJsonParam = createResponse(null, jsonParam);
				resJsonParam.AddField("getPlayerInfo", GetFakePlayerInfo());
				resString = resJsonParam.ToString();
			}

			return resString;
		}

		/**
		 * Native (Java / Objective-C) 영역에서 Unity Engine 영역으로 호출 (for Unity Editor)
		 */
		public void callEngineInEditor(JSONObject jsonParam) {
			// #GCPSDK4-1020, jsonParam 하위 데이터로 JSONObject[] 혹은 JSONObject() 가 포함될 경우
			// jsonParam을 다시 toJSONObject 시 FormatException 발생,
			// ToString하지 않고 json 데이터를 바로 처리하도록 Editor용 callEngine 메서드를 개별 추가

			String className = null;
			jsonParam.GetField(ref className, "class");

			if("Auth".Equals(className)){
				Auth.executeEngine (jsonParam);
			}
			else if("AuthV4".Equals(className)){
				AuthV4.executeEngine(jsonParam);
			}
		}

        public JSONObject callNative(JSONObject jsonParam) {
			String jsonParamString = jsonParam.ToString();
			String resJsonString = callNativeUnity(jsonParamString);
			//에디터용 resJsonString 추가.
			return new JSONObject(resJsonString);
	    }
    }
}
#endif