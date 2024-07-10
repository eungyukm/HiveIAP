/**
 * @file    ExternalDependencyDictionaryManager.cs
 * 
 * @date    2020-2024
 * @copyright Copyright © Com2uS Platform Corporation. All Right Reserved.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.IO;
using System.Xml;

namespace Hive.Unity.Editor
{
    using ExternalDependencyDictionary = Dictionary<ExternalDependencyType, bool>;
    using ExternalDependencySerializableDictionary = SerializableDictionary<string, bool>;

    public class ExternalDependencyDictionaryManager
    {
        /**
         * HiveDependencies SaveFile 저장 경로
         * (버전별 SaveFile 저장 위치 선언)
         */
        // Hive 23.4.0~ xml 파일 저장 위치
        private static string projSettingsXmlDataPath = Path.Combine(Application.dataPath, "../ProjectSettings/HiveDependencies.xml");
        // Hive 23.0.0~ json 파일 저장 위치
        private static string projSettingsJsonDataPath = Path.Combine(Application.dataPath, "../ProjectSettings/HiveExternalDependencyDictionary.json");
        // Hive 4.16.1 ~ 23.0.0 미만 json 파일 저장 위치
        private static string jsonDataPath = Path.Combine(Application.dataPath, "Hive_SDK_v4/Editor/ExternalDependency/externalDependencyDictionary.json");
        // ~ Hive 4.16.1 미만 json 파일 저장 위치
        private static string legacyJsonDataPath = Path.Combine(Application.dataPath, "Hive_SDK_v4/Editor/externalDependencyDictionary.json");


        // Hive 23.0.0 미만에서 업데이트 시 LineProvider를 이미 사용하고 있던 경우 migration을 위한 xml path 추적 용도
        private static string editorLineDependenciesPath = Path.Combine(Application.dataPath, "Hive_SDK_v4/Editor/HIVESDK_ProviderLineDependencies.xml");
        private static string editorHiveStoreDependenciesPath = Path.Combine(Application.dataPath, "Hive_SDK_v4/Editor/HIVESDK_MarketHiveStoreDependencies.xml");

        // Xml Tag Name
        private static string XML_Tag_HiveDependencies = "HiveDependencies";
        private static string XML_Tag_UpdatedInfo = "UpdatedInfo";
        // Xml Attribute Name
        private static string XML_Attr_Include = "include";
        private static string XML_Attr_Version = "version";

        // 구 버전 저장 파일 마이그레이션 지원 범위
        private enum SaveDataVersionType
        {
            Hive4161000,
            Hive4230000,
            Hive4230400,
        }

       
        public static ExternalDependencyDictionary LoadExternalDependencyDictionary()
        {
            Debug.Log(String.Format("[ExternalDependencyDictionaryManager] LoadExternalDependencyDictionary"));

            var dictionary = new ExternalDependencyDictionary();
            Reset(ref dictionary);

            dictionary = LoadSavedFiles(dictionary);

            return dictionary;
        }

        private static ExternalDependencyDictionary migrateLegacySaveData(SaveDataVersionType type, ExternalDependencyDictionary dictionary)
        {
            switch(type)
            {
                case SaveDataVersionType.Hive4161000:
                    return migrateJsonDataToHive4161000Type(dictionary);
                case SaveDataVersionType.Hive4230000:
                    return migrateJsonDataToHive4230000Type(dictionary);
                case SaveDataVersionType.Hive4230400:
                    return migrateSaveDataToHive4230400Type(dictionary);
                default:
                    return dictionary;
            }
        }

        private static ExternalDependencyDictionary LoadSavedFiles(ExternalDependencyDictionary dictionary)
        {
            if (File.Exists(jsonDataPath) || File.Exists(legacyJsonDataPath))
            {
                dictionary = migrateLegacySaveData(SaveDataVersionType.Hive4161000, dictionary);
                dictionary = migrateLegacySaveData(SaveDataVersionType.Hive4230000, dictionary);
            }
            else if (File.Exists(projSettingsJsonDataPath)) {
                dictionary = migrateLegacySaveData(SaveDataVersionType.Hive4230000, dictionary);
            }

            return dictionary = migrateLegacySaveData(SaveDataVersionType.Hive4230400, dictionary);
        }       

        private static ExternalDependencyDictionary migrateSaveDataToHive4230400Type(ExternalDependencyDictionary dictionary)
        {
            // ~ Hive SDK 23.4.0 마이그레이션 처리 (use 'xml format' save file)
            Debug.Log(String.Format("[ExternalDependencyDictionaryManager] migrateSaveDataToHive4230400Type"));

            var tmpDictionary = new ExternalDependencyDictionary();

            if(File.Exists(projSettingsXmlDataPath))
            {
                // Hive SDK 23.4.0 타입 세이브 파일이 있는 경우
                // 파일 내용 반환
                Debug.Log("[ExternalDependencyDictionaryManager] migrateSaveDataToHive4230400Type, exist 4230400Type");
                tmpDictionary = LoadSavedXmlData(projSettingsXmlDataPath);
            }
            else
            {
                // Hive SDK 23.4.0 타입 세이브 파일이 없는 경우
                // 23.4.0 타입 마이그레이션 default 값 설정 
                Debug.Log("[ExternalDependencyDictionaryManager] migrateSaveDataToHive4230400Type, not exist 4230400Type");
                tmpDictionary = dictionary;

                if(File.Exists(editorHiveStoreDependenciesPath)) {
                    // 23.3.0 적용하여 HiveStore xml을 이미 경로에 갖고 있다면 : true
                    tmpDictionary[ExternalDependencyType.MarketHiveStore] = true;
                }
                else {
                    tmpDictionary[ExternalDependencyType.MarketHiveStore] = false;
                }
                tmpDictionary[ExternalDependencyType.AnalyticsConsentMode] = true;

            }
            
            return tmpDictionary;
        }

        private static ExternalDependencyDictionary migrateJsonDataToHive4230000Type(ExternalDependencyDictionary dictionary)
        {
            // ~ Hive SDK 23.0.0 마이그레이션 처리 (use 'json format' save file)
            Debug.Log(String.Format("[ExternalDependencyDictionaryManager] migrateJsonDataToHive4230000Type"));

            var tmpDictionary = new ExternalDependencyDictionary();
            
            if (File.Exists(projSettingsJsonDataPath))
            {
                // Hive SDK 23.0.0 타입 세이브 파일이 있는 경우
                // 파일 내용 반환
                Debug.Log("[ExternalDependencyDictionaryManager] migrateJsonDataToHive4230000Type, exist 4230000Type");
                tmpDictionary = LoadSavedLegacyData(projSettingsJsonDataPath);
            }
            else
            {
                // Hive SDK 23.0.0 타입 세이브 파일이 없는 경우
                // 23.0.0 타입 마이그레이션 default 값 설정 
                Debug.Log("[ExternalDependencyDictionaryManager] migrateJsonDataToHive4230000Type, not exist 4230000Type");
                tmpDictionary = dictionary;

                bool useProviderGoogle = false;
                foreach (KeyValuePair<ExternalDependencyType, bool> pair in tmpDictionary)
                {
                    if(pair.Key.Equals(ExternalDependencyType.Google))
                    {
                        Debug.Log(String.Format("[ExternalDependencyDictionaryManager] migrateJsonDataToHive4230000Type, saved ProviderGoogle : " + pair.Value));
                        useProviderGoogle = pair.Value;
                    }
                }

                // 23.0.0 업데이트 시 추가된 타입의 기본 default : true 처리 필요한 타입
                tmpDictionary[ExternalDependencyType.Apple] = true; 
                tmpDictionary[ExternalDependencyType.AppleSignIn] = true;
                tmpDictionary[ExternalDependencyType.HiveMembership] = true;  
                tmpDictionary[ExternalDependencyType.HivePromotion] = true;
                tmpDictionary[ExternalDependencyType.GoogleInAppReview] = true;                        
                tmpDictionary[ExternalDependencyType.HiveDeviceManagement] = true;                        
                tmpDictionary[ExternalDependencyType.HiveRealNameVerification] = true;
                tmpDictionary[ExternalDependencyType.GoogleInAppUpdate] = true;
                tmpDictionary[ExternalDependencyType.DataStore] = true; 
                tmpDictionary[ExternalDependencyType.PushGoogleFcm] = true;
                tmpDictionary[ExternalDependencyType.MarketApple] = true;                       
                tmpDictionary[ExternalDependencyType.MarketGoogle] = true;
                
                // 23.0.0 업데이트 시 추가된 타입의 기본 default : false 처리 필요한 타입
                tmpDictionary[ExternalDependencyType.FacebookCloud] = false;
                tmpDictionary[ExternalDependencyType.PushFacebookCloudA2u] = false;
                tmpDictionary[ExternalDependencyType.PushAmazonAdm] = false;
                tmpDictionary[ExternalDependencyType.MarketAmazon] = false;
                tmpDictionary[ExternalDependencyType.MarketFacebookCloud] = false;
                tmpDictionary[ExternalDependencyType.MarketSamsung] = false;
                tmpDictionary[ExternalDependencyType.MarketHuawei] = false;
                tmpDictionary[ExternalDependencyType.MarketOneStore] = false;
                tmpDictionary[ExternalDependencyType.MarketLebi] = false;

                // 23.0.0 업데이트 시 추가된 타입의 조건에 따른 true/false 처리
                if(useProviderGoogle)
                {
                    Debug.Log(String.Format("[ExternalDependencyDictionaryManager] migrateJsonDataToHive4230000Type, set ProviderGooglePlayGames : true"));
                    tmpDictionary[ExternalDependencyType.GooglePlayGames] = true;
                }
                else {
                    Debug.Log(String.Format("[ExternalDependencyDictionaryManager] migrateJsonDataToHive4230000Type, set ProviderGooglePlayGames : false"));
                    tmpDictionary[ExternalDependencyType.GooglePlayGames] = false;
                }
            }

            return tmpDictionary;
        }

        private static ExternalDependencyDictionary migrateJsonDataToHive4161000Type(ExternalDependencyDictionary dictionary)
        {
            // ~Hive SDK v4.16.1 마이그레이션 처리 (use 'json format' save file)
            Debug.Log(String.Format("[ExternalDependencyDictionaryManager] migrateJsonDataToHive4161000Type"));
            
            if (File.Exists(legacyJsonDataPath))
            {
                string jsonDataString = File.ReadAllText(legacyJsonDataPath);
                ExternalDependencySerializableDictionary serializableDictionary = JsonUtility.FromJson<ExternalDependencySerializableDictionary>(jsonDataString);

                foreach (KeyValuePair<string, bool> pair in serializableDictionary)
                {
                    int i = 0;
                    bool isNumbericKey = int.TryParse(pair.Key, out i);

                    if(isNumbericKey)
                    {   
                        string legacyName = Enum.GetName(typeof(LegacyExternalDependencyType), i);
                        ExternalDependencyType externalDependencyType;
                        if (Enum.TryParse(legacyName, out externalDependencyType))
                        {
                            if (Enum.IsDefined(typeof(ExternalDependencyType), externalDependencyType))
                            {
                                dictionary[externalDependencyType] = pair.Value;
                            }
                            else
                            {
                                Debug.Log(String.Format("[ExternalDependencyDictionaryManager] migrateJsonDataToHive4161000Type, {0} is not an underlying value of the ExternalDependencyType enumeration.", pair.Key));
                                continue;
                            }
                        }
                        else
                        {
                            Debug.Log(String.Format("[ExternalDependencyDictionaryManager] migrateJsonDataToHive4161000Type, {0} is not a member of the ExternalDependencyType enumeration.", pair.Key));
                            continue;
                        }
                    }
                    else
                    {
                        Debug.Log(String.Format("[ExternalDependencyDictionaryManager] migrateJsonDataToHive4161000Type, {0} is broken.", legacyJsonDataPath));
                    }
                }
            }
            else if (File.Exists(jsonDataPath))
            {
                dictionary = LoadSavedLegacyData(jsonDataPath);
            }

            return dictionary;
        }

        private static void removeSaveData(string path)
        {
            Debug.Log(String.Format("[ExternalDependencyDictionaryManager] removeSaveData"));

            if (File.Exists(path))
            {
                try
                {
                    File.Delete(path);
                }
                catch (Exception ex)
                {
                    Debug.Log(String.Format("[ExternalDependencyDictionaryManager] removeSaveData, File.Delete({0}) Exception. \n {1}", path, ex.ToString()));
                }
            }
        }

        public static bool isUseDependency(ExternalDependencyType type) {
            // 저장된 xml 데이터에서 사용중 여부 확인
            // (저장된 데이터가 없는 경우 더이상 reset()을 통해 default를 생성하지 않음, Hive 23.0.0)
            var dictionary = LoadSavedXmlData(projSettingsXmlDataPath);

            foreach(KeyValuePair<ExternalDependencyType, bool> pair in dictionary)
            {
                if(pair.Key == type)
                {
                    return pair.Value;
                }
            }
            return false;
        }

        private static ExternalDependencyDictionary LoadSavedLegacyData(string filePath) {
            Debug.Log(String.Format("[ExternalDependencyDictionaryManager] LoadSavedLegacyData"));

            var dictionary = new ExternalDependencyDictionary();

            if (File.Exists(filePath))
            {
                string jsonDataString = File.ReadAllText(filePath);
                ExternalDependencySerializableDictionary serializableDictionary = JsonUtility.FromJson<ExternalDependencySerializableDictionary>(jsonDataString);

                foreach (KeyValuePair<string, bool> pair in serializableDictionary)
                {
                    ExternalDependencyType externalDependencyType;
                    if (Enum.TryParse(pair.Key, out externalDependencyType))
                    {
                        if (Enum.IsDefined(typeof(ExternalDependencyType), externalDependencyType))
                        {
                            dictionary[externalDependencyType] = pair.Value;
                        }
                        else
                        {
                            Debug.Log(String.Format("[ExternalDependencyDictionaryManager] LoadSavedLegacyData, {0} is not an underlying value of the ExternalDependencyType enumeration.", pair.Key));
                            continue;
                        }
                    }
                    else
                    {
                        Debug.Log(String.Format("[ExternalDependencyDictionaryManager] LoadSavedLegacyData, {0} is not a member of the ExternalDependencyType enumeration.", pair.Key));
                        continue;
                    }
                }
            }
            else
            {
                Debug.Log("[ExternalDependencyDictionaryManager] LoadSavedLegacyData, file not exist");
            }

            return dictionary;
        }

        private static ExternalDependencyDictionary LoadSavedXmlData(string filePath) {
            Debug.Log(String.Format("[ExternalDependencyDictionaryManager] LoadSavedXmlData"));

            var dictionary = new ExternalDependencyDictionary();

            if (File.Exists(filePath))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(projSettingsXmlDataPath);

                XmlElement elHiveDependencies = doc[XML_Tag_HiveDependencies];

                foreach(XmlElement element in elHiveDependencies.ChildNodes)
                {
                    ExternalDependencyType externalDependencyType;
                    if (Enum.TryParse(element.Name, out externalDependencyType))
                    {
                        if (Enum.IsDefined(typeof(ExternalDependencyType), externalDependencyType))
                        {
                            bool include = false;
                            if(element.GetAttribute(XML_Attr_Include).Equals("true"))
                                include = true;
                            dictionary[externalDependencyType] = include;
                        }
                        else {
                            Debug.Log(String.Format("[ExternalDependencyDictionaryManager] LoadSavedXmlData, {0} is not an underlying value of the ExternalDependencyType enumeration.", element.Name));
                            continue;
                        }
                    }
                    else
                    {
                        Debug.Log(String.Format("[ExternalDependencyDictionaryManager] LoadSavedXmlData, {0} is not a member of the ExternalDependencyType enumeration.", element.Name));
                        continue;
                    }
                }
            }
            else
            {
                Debug.Log("[ExternalDependencyDictionaryManager] LoadSavedXmlData, file not exist");
            }
            return dictionary;
        }

        private static string GetUpdatedXmlVersion(string filePath) {
            Debug.Log(String.Format("[ExternalDependencyDictionaryManager] GetUpdatedXmlVersion"));

            string updatedVersion = "";

            if (File.Exists(filePath))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(projSettingsXmlDataPath);

                XmlElement elHiveDependencies = doc[XML_Tag_HiveDependencies];

                foreach(XmlElement element in elHiveDependencies.ChildNodes)
                {
                    if(element.Name.Equals(XML_Tag_UpdatedInfo))
                    {
                        updatedVersion = element.GetAttribute(XML_Attr_Version);
                    }
                }
            }

            Debug.Log(String.Format("[ExternalDependencyDictionaryManager] GetUpdatedXmlVersion, updatedVersion : " + updatedVersion));
            return updatedVersion;
        }

        public static void SaveExternalDependencyDictionary(ref ExternalDependencyDictionary externalDependencyDictionary)
        {
            Debug.Log(String.Format("[ExternalDependencyDictionaryManager] SaveExternalDependencyDictionary"));

            // Save Xml File
            XmlDocument doc = new XmlDocument();
            XmlElement elHiveDependencies = doc.CreateElement(XML_Tag_HiveDependencies);
            doc.AppendChild(elHiveDependencies);

            foreach (var pair in externalDependencyDictionary)
            {
                XmlElement elProvider = doc.CreateElement(Enum.GetName(typeof(ExternalDependencyType), pair.Key));

                string boolValue = "false";
                if(pair.Value == true) {
                    boolValue = "true";
                }
                elProvider.SetAttribute(XML_Attr_Include, boolValue);
                elHiveDependencies.AppendChild(elProvider);
            }

            XmlElement elUpdatedInfo = doc.CreateElement(XML_Tag_UpdatedInfo);
            elUpdatedInfo.SetAttribute(XML_Attr_Version, Enum.GetName(typeof(SaveDataVersionType), SaveDataVersionType.Hive4230400));
            elHiveDependencies.AppendChild(elUpdatedInfo);

            doc.Save(projSettingsXmlDataPath);

            // "Xml Example"
            //
            // <HiveDependencies>
            //     <Google include="true" />
            //     <GooglePlayGames include="true" />
            //     <Facebook include="true" />
            //     ...
            //     <MarketHiveStore include="true" />
            //     <UpdatedInfo version="Hive4230400" />
            // </HiveDependencies>

            // remove legacySaveData
            removeSaveData(legacyJsonDataPath);         // 4.16.1 미만 버전 저장위치
            removeSaveData(jsonDataPath);               // 4.16.1 이상 23.0.0 미만 버전 저장위치
            removeSaveData(projSettingsJsonDataPath);   // 23.0.0 이상 23.4.0 미만 버전 저장위치
        }

        public static void Reset(ref ExternalDependencyDictionary dictionary)
        {
            Debug.Log(String.Format("[ExternalDependencyDictionaryManager] Reset"));

            dictionary.Clear();

            foreach (ExternalDependencyType i in Enum.GetValues(typeof(ExternalDependencyType)))
            {
                if(i == ExternalDependencyType.HiveRealNameVerification
                    || i == ExternalDependencyType.FacebookCloud
                    || i == ExternalDependencyType.VK
                    || i == ExternalDependencyType.QQ
                    || i == ExternalDependencyType.Wechat
                    || i == ExternalDependencyType.Weverse
                    || i == ExternalDependencyType.Huawei
                    || i == ExternalDependencyType.PushFacebookCloudA2u
                    || i == ExternalDependencyType.PushAmazonAdm
                    || i == ExternalDependencyType.MarketOneStore
                    || i == ExternalDependencyType.MarketAmazon
                    || i == ExternalDependencyType.MarketLebi
                    || i == ExternalDependencyType.MarketHiveStore
                    || i == ExternalDependencyType.MarketFacebookCloud
                    || i == ExternalDependencyType.MarketSamsung
                    || i == ExternalDependencyType.MarketHuawei
                    || i == ExternalDependencyType.Adjust
                    || i == ExternalDependencyType.AppsFlyer
                    || i == ExternalDependencyType.Singular
                    || i == ExternalDependencyType.Firebase)
                {
                    // default:false 설정 대상
                    dictionary[i] = false;
                    Debug.Log(String.Format("[ExternalDependencyDictionaryManager] Reset, {0} default : false", i));
                }
#if UNITY_ANDROID
                else if(i == ExternalDependencyType.Line)
                {
                    // GCPSDK4-1498, Reset Line default = false
                    // LineDependency xml 파일을 이미 갖고 있는 상태에서 Reset한 경우 xml 파일 제거 
                    dictionary[i] = false;
                    if(File.Exists(editorLineDependenciesPath)) {
                        File.Delete(editorLineDependenciesPath);
                    }
                    Debug.Log(String.Format("[ExternalDependencyDictionaryManager] Reset, line default(Android) : false"));
                }
#endif
                else
                {
                    // "default값이 false 처리되야할 것 + 개별 조건" 외의 것들은 true 설정
                    dictionary[i] = true;
                }
            }
        }

        public enum LegacyExternalDependencyType
        {
            // IDP
            Google,
            Facebook,
            Line,
            VK,
            QQ,
            Wechat,

            // Analytics
            Adjust,
            Singular,
            AppsFlyer,
            Firebase,

            // Push
            Fcm,

            // Etc
            Recaptcha,
            AndroidEmoji,
        }

    }

}   