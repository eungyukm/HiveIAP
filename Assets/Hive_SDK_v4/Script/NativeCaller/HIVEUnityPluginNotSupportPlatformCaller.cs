/**
 * @file    HIVEUnityPluginNotSupportPlatformCaller.cs
 * @brief   미지원 플랫폼 IHIVEUnityPluginNativeCaller 구현
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

namespace hive
{
	public class HIVEUnityPluginNotSupportPlatformCaller : IHIVEUnityPluginNativeCaller{
        public JSONObject callNative(JSONObject jsonParam) {
            return new JSONObject();
        }
    }
}