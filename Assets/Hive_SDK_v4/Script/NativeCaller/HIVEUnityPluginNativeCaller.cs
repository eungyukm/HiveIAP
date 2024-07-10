/**
 * @file    IHIVEUnityPluginNativeCaller.cs
 * @brief   통신 브릿지 인터페이스
 * 
 * @ingroup hive
 * @author  cocororo
 * @date    2023 ~ Present.
 * @copyright Copyright © Com2uS Platform Corporation. All Right Reserved.
 */

using System;
using System.Text;

namespace hive
{
    public interface IHIVEUnityPluginNativeCaller {
        JSONObject callNative(JSONObject jsonParam);
    }
}