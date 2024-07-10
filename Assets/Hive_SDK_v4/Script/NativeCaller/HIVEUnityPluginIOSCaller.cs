/**
 * @file    HIVEUnityPluginIOSCaller.cs
 * @brief   iOS Unity 통신 브릿지
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
using System.Threading.Tasks;
using AOT;

#if !UNITY_EDITOR && UNITY_IPHONE
namespace hive
{
	public class HIVEUnityPluginIOSCaller : IHIVEUnityPluginNativeCaller {
        
		[DllImport("__Internal")]
		public static extern IntPtr HivePlugin_callNative_u(String jsonParam);

        public JSONObject callNative(JSONObject jsonParam) {
			String jsonParamString = jsonParam.ToString();
			String resJsonString = Marshal.PtrToStringAuto(HivePlugin_callNative_u(jsonParamString));
			return new JSONObject(resJsonString);

        }
    }
}
#endif