/**
 * @file    IHivePreprocess.cs
 * @brief   Unity 빌드 전처리 인터페이스
 * 
 * @ingroup hive
 * @author  disker
 * @date    2024 ~ Present.
 * @copyright Copyright © Com2uS Platform Corporation. All Right Reserved.
 */
using UnityEditor.Build.Reporting;

namespace Hive.Unity.Editor
{
    public interface IHivePreprocess
    {
        void OnPreprocessBuild(BuildReport report);
    }
}