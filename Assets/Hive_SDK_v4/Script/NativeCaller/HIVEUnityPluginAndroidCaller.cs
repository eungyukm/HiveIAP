/**
 * @file    HIVEUnityPluginAndroidCaller.cs
 * @brief   Android Unity 통신 브릿지
 * 
 * @ingroup hive
 * @author  cocororo
 * @date    2023 ~ Present.
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

#if !UNITY_EDITOR && UNITY_ANDROID
namespace hive
{
	public class HIVEUnityPluginAndroidCaller : IHIVEUnityPluginNativeCaller{
        private static AndroidJavaClass _androidClass;

        public HIVEUnityPluginAndroidCaller() {
            _androidClass = new AndroidJavaClass("com.hive.plugin.HivePluginUnity");
        }
        
        public JSONObject callNative(JSONObject jsonParam) {
			String jsonParamString = jsonParam.ToString();
			String resJsonString = _androidClass.CallStatic<String>("callNative", jsonParamString);
			return new JSONObject(resJsonString);
	    }
    }
}
#endif