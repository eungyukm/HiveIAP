/**
 * @file    HIVEUnityPluginStandaloneCaller.cs
 * @brief   Standalone Unity 통신 브릿지
 * 
 * @ingroup hive
 * @author  cocororo
 * @date    2023 ~ Present.
 * @copyright Copyright © Com2uS Platform Corporation. All Right Reserved.
 */

using System;
using System.Collections;
using System.Runtime.InteropServices;
using AOT;
using UnityEngine;

#if !UNITY_EDITOR && UNITY_STANDALONE
namespace hive {

	public class HIVEUnityPluginStandaloneCaller : MonoBehaviour, IHIVEUnityPluginNativeCaller {
		static MainThreadDispatcher mainThreadDispatcher = null;

		void Awake() {
			initSendMessage();	
		}

		#region 플러그인 호출을 위한 정의 및 구현
		[DllImport("HIVE_PLUGIN")]
		public static extern IntPtr HivePlugin_callNative_u(String jsonParam);
		[DllImport("HIVE_PLUGIN")]
		public static extern void HivePlugin_callNative_after(IntPtr ptr1);
		
        public JSONObject callNative(JSONObject jsonParam) {
			
            String jsonParamString = jsonParam.ToString();
            IntPtr resultString = HivePlugin_callNative_u(jsonParamString);
#if UNITY_STANDALONE_OSX
			String resJsonString = Marshal.PtrToStringAuto(resultString);
#elif UNITY_STANDALONE_WIN
			String resJsonString = Marshal.PtrToStringAnsi(resultString);
#endif
			if(!String.IsNullOrEmpty(resJsonString))
				HivePlugin_callNative_after(resultString);
			return new JSONObject(resJsonString);
        }

		#endregion

		#region 네이티브 플러그인으로부터 이벤트 수신을 위한 정의 및 구현
		
		void initSendMessage() {
			mainThreadDispatcher = gameObject.AddComponent<MainThreadDispatcher>();
			s_SendMessageDelegate = UnitySendMessageWrapper;
			SetUnitySendMessageCallback(s_SendMessageDelegate);
		}
		
		[DllImport("HIVE_PLUGIN")]
		private static extern void SetUnitySendMessageCallback(UnitySendMessageDelegate sendMessage);

		public delegate void UnitySendMessageDelegate([MarshalAs(UnmanagedType.LPStr)]string gameObjectName, [MarshalAs(UnmanagedType.LPStr)]string methodName, [MarshalAs(UnmanagedType.LPStr)]string message);
		
		private static UnitySendMessageDelegate s_SendMessageDelegate;
		
		[MonoPInvokeCallback (typeof(UnitySendMessageDelegate))]
		private static void UnitySendMessageWrapper(string gameObjectName, string methodName, string message)
		{
			if (mainThreadDispatcher != null)
				mainThreadDispatcher.Enqueue(UnitySendMessageOnTheMainThread(gameObjectName, methodName, message)); 
		}
		
		public static IEnumerator UnitySendMessageOnTheMainThread(string gameObjectName, string methodName, string message) {
			var gameObject = GameObject.Find(gameObjectName);
			if (gameObject != null)
			{
				gameObject.SendMessage(methodName, message);
			}
			yield return null;
		}

		#endregion
	}
}

#endif