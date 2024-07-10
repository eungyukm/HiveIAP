using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

#if UNITY_EDITOR
public class HivePostProcessMenu
{
    [MenuItem("Hive/Build project post process settings/iOS")]
    public static void showHivePostProcessEditorIOS() {
        HivePostProcessEditorIOS.ShowWindow();
    }
}
#endif