using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;
using hive;

public class HivePostProcessFileIOS {
    private string fileName;
    private string filePath;

    public HivePostProcessFileIOS() {
        fileName = "HivePostProcessSettingIOS.txt";
        filePath = "Assets/Hive_SDK_v4/Editor/PostProcess/iOS/" + fileName;
    }

    public void writePostProcessSetting(Dictionary<string, string> setting) {
        cleanFile(filePath);

        var jsonObj = new JSONObject(setting);
        var jsonString = jsonObj.ToString();
        
        var writer = new StreamWriter(filePath, true);
        writer.WriteLine(jsonString);
        writer.Close();
        
        #if UNITY_EDITOR
        AssetDatabase.ImportAsset(filePath);
        #endif 
    }

    public Dictionary<string, string> readPostProcessSetting() {
        if (!isFileExist(filePath)) {
            return null;
        }
        
        var reader = new StreamReader(filePath); 
        var jsonString = reader.ReadToEnd();
        reader.Close();

        var jsonObj = new JSONObject(jsonString);
        var dictionary = jsonObj.ToDictionary();

        return dictionary;
    }

    private bool isFileExist(string filePath) {
        if (File.Exists(filePath)) {
            return true;
        }
        return false;
    }

    private void cleanFile(string filePath) {
        if (!isFileExist(filePath)) {
            return;
        }
        File.WriteAllText(filePath, string.Empty);
    }
}
