/**
 * @file    HivePreprocess.cs
 * 
 * @author  disker
 * @date    2019-2022
 * @copyright	Copyright © Com2uS Platform Corporation. All Right Reserved.
 * @defgroup UnityEditor.HiveEditor
 * @{
 * @brief PrePrcessing on BuildTime <br/><br/>
 */

namespace UnityEditor.HiveEditor
{
    using UnityEditor;
    using UnityEditor.Build;
    using Hive.Unity.Editor;
    using UnityEngine;
    using System.IO;

#if UNITY_IOS
    using UnityEditor.iOS;
    using UnityEditor.iOS.Xcode;
#endif

#if UNITY_2018_1_OR_NEWER
    using UnityEditor.Build.Reporting;
    public class HivePreProcess : IPreprocessBuildWithReport
    {
        public int callbackOrder { get { return 0; } }
        public void OnPreprocessBuild(BuildReport report)
        {
            if (HiveConfigEditor.isAutoValidation())
            {
                Utility.XmlValidator.getInstance().execute();
            }

        #if UNITY_ANDROID
            new HiveAndroidPreprocess().OnPreprocessBuild(report);
        #endif
        
        }
    }
#endif

//  IPreprocessBuild is Obsolete on (ver.2018.1~)
#if !UNITY_2018_1_OR_NEWER
    public class HivePreProcess : IPreprocessBuild
    {
        public int callbackOrder { get { return 0; } }
        public void OnPreprocessBuild(BuildTarget target, string path)
        {
            if (HiveConfigEditor.isAutoValidation())
            {
                Utility.XmlValidator.getInstance().execute();
            }

        }
    }
#endif

}
