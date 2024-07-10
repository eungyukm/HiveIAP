/**
 * @file    HiveUnity.cs
 * @brief   Unity 통신 브릿지
 * 
 * @ingroup hive
 * @author  ryuvsken
 * @date    2016-2022
 * @copyright Copyright © Com2uS Platform Corporation. All Right Reserved.
 */
using UnityEngine;
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading.Tasks;	// for 	custom UnitySendMessage implement
using AOT;

namespace hive
{
	/**
	 * @brief Unity 통신 브릿지
	 * 
	 * @ingroup hive
	 * @author ryuvsken
	 */
	public class HIVEUnityPlugin : MonoBehaviour {
#if UNITY_EDITOR || UNITY_STANDALONE
		void OnApplicationQuit()
		{
			JSONObject jsonParam = HIVEUnityPlugin.createParam("AuthV4", "terminateProcess", null);
			HIVEUnityPlugin.callNative(jsonParam);
		}
#endif

		private static IHIVEUnityPluginNativeCaller nativeCaller;
		private static IHIVEUnityPluginNativeCaller createNativeCaller(GameObject gameObject) {
#if !UNITY_EDITOR
#if UNITY_ANDROID
			return new HIVEUnityPluginAndroidCaller();
#elif UNITY_IPHONE
			return new HIVEUnityPluginIOSCaller();
#elif UNITY_STANDALONE
			// HIVEUnityPluginStandaloneCaller는 MonoBehaviour를 사용하므로 AddComponent를 사용합니다.
			return gameObject.AddComponent<HIVEUnityPluginStandaloneCaller>();
#else
			return new HIVEUnityPluginNotSupportPlatformCaller();
#endif
#else
			return new HIVEUnityPluginEditorCaller(currentPlugin);
#endif
		}

		public static String targetObject;

		public static int handlerId = 0;

		public static Dictionary<int, object> callbackHandler = new Dictionary<int, object>();

		public static Dictionary<int, object> openCallbackHandler = new Dictionary<int, object>();
		public static Dictionary<int, object> closeCallbackHandler = new Dictionary<int, object>();
		public static Dictionary<int, object> startPlaybackCallbackHandler = new Dictionary<int, object>();
		public static Dictionary<int, object> finishPlaybackCallbackHandler = new Dictionary<int, object>();
		public static Dictionary<int, object> exitCallbackHandler = new Dictionary<int, object>();

		public static object userEngagementHandler;
		public static object authV4ProviderChangeHandler;
#if UNITY_EDITOR || UNITY_STANDALONE
		static HIVEUnityPlugin currentPlugin;
#endif
		
		public static void InitPlugin(){
			var hiveObj = new GameObject();
			hiveObj.name = "HIVEUnityPluginObject(DontDestroyOnLoad)";
#if UNITY_EDITOR || UNITY_STANDALONE
			currentPlugin = 
#endif
			hiveObj.AddComponent<HIVEUnityPlugin>();

		}

		public void Awake()
		{
#if !UNITY_EDITOR
			DontDestroyOnLoad(gameObject);
#endif
#if UNITY_EDITOR || UNITY_STANDALONE
			currentPlugin = this;
#endif
			nativeCaller = createNativeCaller(gameObject);
			HIVEUnityPlugin.targetObject = this.name;
		}

		public static JSONObject createParam(string className, string methodName, object handler) {

			JSONObject jsonParam = new JSONObject ();
			jsonParam.AddField ("targetObject", HIVEUnityPlugin.targetObject);
			jsonParam.AddField ("class", className);
			jsonParam.AddField ("method", methodName);
			jsonParam.AddField ("platform", "unity");

			if ("Promotion".Equals(className)) {
				if( handler != null &&
				methodName != null ) {
					jsonParam.AddField ("handler", pushPromotionHandler(methodName, handler));
				}
			}
			else if ("AuthV4".Equals(className) && "setProviderChangedListener".Equals(methodName)) {
				if (handler != null && methodName != null) {
					jsonParam.AddField("handler", pushAuthV4Handler(methodName, handler));
				}
			}
			// else if("UserEngagement".Equals(className)) {
			// 	if( handler != null && methodName != null ) {
			// 		setEngagementHandler(methodName, handler);
			// 	}
			// }
			else if (handler != null) {
				jsonParam.AddField ("handler", HIVEUnityPlugin.pushHandler (handler));
			}
			return jsonParam;
		}


		public static int pushHandler(object handler) {

			int newHandlerId = HIVEUnityPlugin.handlerId++;
			callbackHandler [newHandlerId] = handler;
			return newHandlerId;
		}


		public static object popHandler(int handlerIdParam) {

			if (callbackHandler.ContainsKey(handlerIdParam) == false) return null;

			object handler = callbackHandler [handlerIdParam];
			if (handler != null) {
				callbackHandler.Remove (handlerIdParam);
			}
			return handler;
		}

		// public static void setEngagementHandler(string methodName, object handler) {

		// 	if ("setEngagementHandler".Equals(methodName)) {
		// 		userEngagementHandler = handler;
		// 	}
		// }

		// public static object getEngagementHandler() {

		// 	return userEngagementHandler;
		// }
		public static int pushAuthV4Handler(string methodName, object handler) {
			int newHandlerId = HIVEUnityPlugin.handlerId++;
			if("setProviderChangedListener".Equals(methodName)) {
				authV4ProviderChangeHandler = handler;
			} else {
				pushHandler(handler);
			}
			return newHandlerId;
		}

		public static object popAuthV4Handler(JSONObject jsonObject) {
			String methodName = null;
			jsonObject.GetField(ref methodName, "method");

			int handlerId = -1;
			jsonObject.GetField (ref handlerId, "handler");

			object handler = null;
			if("setProviderChangedListener".Equals(methodName)) {
				handler = authV4ProviderChangeHandler;
			} else {
				handler = (object)HIVEUnityPlugin.popHandler(handlerId);
			}
			return handler;
		}
		public static int pushPromotionHandler(string methodName, object handler) {

			int newHandlerId = HIVEUnityPlugin.handlerId++;

			if ("showPromotion".Equals (methodName) ||
				"showCustomContents".Equals (methodName) ||
				"showCustomContentsOnGameWindow".Equals (methodName) ||
				"showOfferwall".Equals(methodName) ||
				"showNews".Equals(methodName) ||
				"showReview".Equals (methodName)) {

				openCallbackHandler [newHandlerId] = handler;
				closeCallbackHandler [newHandlerId] = handler;
				startPlaybackCallbackHandler [newHandlerId] = handler;
				finishPlaybackCallbackHandler [newHandlerId] = handler;
			}
			else if ("showExit".Equals(methodName)) {

				openCallbackHandler [newHandlerId] = handler;
				closeCallbackHandler [newHandlerId] = handler;
				exitCallbackHandler [newHandlerId] = handler;
			}
			else if ("setEngagementHandler".Equals(methodName)) {
				userEngagementHandler = handler;
			}
			else {
				callbackHandler [newHandlerId] = handler;
			}
			
			return newHandlerId;
		}

		public static object popPromotionHandler(JSONObject jsonObject) {

			String methodName = null;
			jsonObject.GetField (ref methodName, "method");

			int handlerId = -1;
			jsonObject.GetField (ref handlerId, "handler");

			if (handlerId == -1) return null;

			String eventValue = "";
			jsonObject.GetField (ref eventValue, "promotionEventType");

			object handler = null;

			if ("showPromotion".Equals (methodName) ||
			    "showCustomContents".Equals (methodName) ||
				"showCustomContentsOnGameWindow".Equals (methodName) ||
			    "showOfferwall".Equals (methodName) ||
				"showNews".Equals(methodName) ||
				"showReview".Equals (methodName) ||
			    "showExit".Equals (methodName)) {

				if ("OPEN".Equals (eventValue.ToUpper ())) {
					openCallbackHandler.TryGetValue(handlerId, out handler);
					if (handler != null) openCallbackHandler.Remove (handlerId);
				}
				else if ("CLOSE".Equals (eventValue.ToUpper ())) {
					closeCallbackHandler.TryGetValue(handlerId, out handler);
					if (handler != null) closeCallbackHandler.Remove (handlerId);
				}	
				else if ("START_PLAYBACK".Equals (eventValue.ToUpper ())) {
					startPlaybackCallbackHandler.TryGetValue(handlerId, out handler);
					if (handler != null) startPlaybackCallbackHandler.Remove (handlerId);
				}	
				else if ("FINISH_PLAYBACK".Equals (eventValue.ToUpper ())) {
					finishPlaybackCallbackHandler.TryGetValue(handlerId, out handler);
					if (handler != null) finishPlaybackCallbackHandler.Remove (handlerId);
				}	
				else if ("EXIT".Equals (eventValue.ToUpper ())) {
					exitCallbackHandler.TryGetValue(handlerId, out handler);
					if (handler != null) exitCallbackHandler.Remove (handlerId);
				}
			}
			else if ("setEngagementHandler".Equals (methodName)) {
				handler = userEngagementHandler;
			}
			else {
				callbackHandler.TryGetValue(handlerId, out handler);
				if (handler != null) callbackHandler.Remove (handlerId);
			}

			return handler;
		}

		/**
		 * Unity Engine 영역에서 Native (Java / Objective-C) 영역으로 호출
		 */
		public static JSONObject callNative(JSONObject jsonParam) {
			return nativeCaller.callNative(jsonParam);
		}

#if UNITY_EDITOR
		public struct AuthV1LoginData {
			public static String did;
			public static String vid;
			public static String accessToken;
		}

		public struct AuthV4LoginData {
			public static Int64 playerId;
			public static String playerName;
			public static String playerImageUrl;
			public static String playerToken;
			public static String did;
		}
#endif

		/**
		 * Native (Java / Objective-C) 영역에서 Unity Engine 영역으로 호출
		 */
		public void callEngine(String jsonParam) {

			JSONObject resJsonObject = new JSONObject (jsonParam);

			String className = null;
			resJsonObject.GetField (ref className, "class");

			if ("Analytics".Equals (className)) {
				Analytics.executeEngine (resJsonObject);
			}
			else if("Configuration".Equals(className)){
				Configuration.executeEngine (resJsonObject);
			}
			else if("Auth".Equals(className)){
				Auth.executeEngine (resJsonObject);
			}
			else if("AuthV4".Equals(className)){
				AuthV4.executeEngine(resJsonObject);
			}
			else if("SocialHive".Equals(className)){
				SocialHive.executeEngine (resJsonObject);
			}
			else if("SocialFacebook".Equals(className)){
				SocialFacebook.executeEngine (resJsonObject);
			}
			else if("SocialGoogle".Equals(className)){
				SocialGoogle.executeEngine (resJsonObject);
			}
			else if("Promotion".Equals(className)){
				Promotion.executeEngine (resJsonObject);
			}
			else if("Push".Equals(className)){
				Push.executeEngine (resJsonObject);
			}
			else if("IAPV4".Equals(className)){
				IAPV4.executeEngine (resJsonObject);
			}
			else if("PlatformHelper".Equals(className)){
				PlatformHelper.executeEngine(resJsonObject);
			}
			// else if("UserEngagement".Equals(className)){
			// 	UserEngagement.executeEngine(resJsonObject);
			// }
#if !UNITY_EDITOR && UNITY_ANDROID
			else if("ProviderGoogle".Equals(className)){
				ProviderGoogle.executeEngine(resJsonObject);
			}
#elif !UNITY_EDITOR && UNITY_IPHONE
			else if("ProviderApple".Equals(className)){
				ProviderApple.executeEngine(resJsonObject);
			}
#endif // !UNITY_EDITOR && UNITY_ANDROID or !UNITY_EDITOR && UNITY_IPHONE
			else if("AuthV4Helper".Equals(className)){
				AuthV4.Helper.executeEngine(resJsonObject);
			}
			else if("SocialV4".Equals(className)) {
				SocialV4.executeEngine(resJsonObject);
			}
			else if("DataStore".Equals(className)) {
				DataStore.executeEngine(resJsonObject);
			}
		}

#if UNITY_STANDALONE_WIN
		public static IMECompositionMode savedInputMode;
#endif
		public static void IMECompositionModeOn()
        {
#if UNITY_STANDALONE_WIN
			savedInputMode = Input.imeCompositionMode;
			Input.imeCompositionMode = IMECompositionMode.On;
#endif
		}
		public static void IMECompositionModeRestore()
        {
#if UNITY_STANDALONE_WIN
			Input.imeCompositionMode = savedInputMode;
#endif
		}
	}

}



