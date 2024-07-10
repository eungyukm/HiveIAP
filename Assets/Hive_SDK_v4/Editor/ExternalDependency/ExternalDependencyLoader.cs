/**
 * @file    ExternalDependencyLoader.cs
 * 
 * @author  jschoi
 * @date    2024~
 * @copyright Copyright © Com2uS Platform Corporation. All Right Reserved.
 * @defgroup Hive.Unity.Editor
 * @{
 * @brief HIVE External Dependency 로컬 경로 동기화 <br/><br/>
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.IO;
using System.ComponentModel;
using System.Reflection;
using System.Xml;

namespace Hive.Unity.Editor
{    
    using ExternalDependencyDictionary = Dictionary<ExternalDependencyType, bool>;
    using ExternalDependencySerializableDictionary = SerializableDictionary<string, bool>;

    [InitializeOnLoad]
    public class ExternalDependencyLoader
    {
        private static string projSettingsXmlDataPath = Path.Combine(Application.dataPath, "../ProjectSettings/HiveDependencies.xml");
        private static string projSettingsJsonDataPath = Path.Combine(Application.dataPath, "../ProjectSettings/HiveExternalDependencyDictionary.json");
        private static string projPopupSaveFilePath = Path.Combine(Application.dataPath, "../ProjectSettings/HiveEditorSettings.txt");
        private static string editorPath = Path.Combine(Application.dataPath, "Hive_SDK_v4/Editor");
        private static string sampleFilePath = Path.Combine(Application.dataPath, "SampleBuilder/Editor/AndroidSamplePostBuildProcessor.cs");


        static ExternalDependencyLoader()
        {
            // Hive Sample 빌드 프로젝트가 아닌 경우만 동기화
            if(!File.Exists(sampleFilePath))//
            {
                // json 파일과 xml 파일 중 정상적인 상황에선 1개의 파일만 존재
                // 최신 업데이트 형태인 Xml 파일을 가장 나중에 확인하도록 순서 조치
                removeNotUseDepXmlFromJson();
                removeNotUseDepXmlFromXml();

                // 23.0.0 업데이트 시 Hive Dependenices 저장 유도 팝업 노출 시간 저장된 파일 제거
                // (해당 팝업을 23.4.0 부터 사용하지 않음)
                removeFile(projPopupSaveFilePath);
            }
        }

        // HiveDependencies xml을 불러오기해서 true로 되어있는 것 외에
        // /editor 이하의 xml은 제거 (23.4.0 HiveDependencies xml 저장 파일 형식 사용)
        private static void removeNotUseDepXmlFromXml()
        {
            Debug.Log(String.Format("[ExternalDependencyLoader] removeNotUseDepXmlFromXml"));

            if(File.Exists(projSettingsXmlDataPath))
            {
                Debug.Log(String.Format("[ExternalDependencyLoader] removeNotUseDepXmlFromXml, found xmlSaveFile"));

                // 파일 읽기
                XmlDocument doc = new XmlDocument();
                doc.Load(projSettingsXmlDataPath);

                XmlElement elHiveDependencies = doc["HiveDependencies"];

                // HiveDependencies 이하 provider 요소 순환 확인
                foreach(XmlElement element in elHiveDependencies.ChildNodes)
                {
                    ExternalDependencyType externalDependencyType;
                    if (Enum.TryParse(element.Name, out externalDependencyType))
                    {
                        if (Enum.IsDefined(typeof(ExternalDependencyType), externalDependencyType))
                        {
                            // element에 새겨진 속성값 미사용인지 확인
                            if(element.GetAttribute("include").Equals("false")) 
                            {
                                removeDependenciesXml(element.Name);
                            }
                        }
                    }
                }
            }
            else
            {
                Debug.Log(String.Format("[ExternalDependencyLoader] removeNotUseDepXmlFromXml, not exist xmlSaveFile"));
            }
        }

        // HiveDependencies xml을 불러오기해서 true로 되어있는 것 외에
        // /editor 이하의 xml은 제거 (23.0.0 HiveDependencies json 저장 파일 형식 사용)
        private static void removeNotUseDepXmlFromJson()
        {
            Debug.Log(String.Format("[ExternalDependencyLoader] removeNotUseDepXmlFromJson"));

            if(File.Exists(projSettingsJsonDataPath))
            {
                // 파일 읽기
                Debug.Log(String.Format("[ExternalDependencyLoader] removeNotUseDepXmlFromJson, found jsonSaveFile"));

                string jsonDataString = File.ReadAllText(projSettingsJsonDataPath);
                ExternalDependencySerializableDictionary serializableDictionary = JsonUtility.FromJson<ExternalDependencySerializableDictionary>(jsonDataString);

                // HiveDependencies 이하 provider 요소 순환 확인
                foreach (KeyValuePair<string, bool> pair in serializableDictionary)
                {
                    ExternalDependencyType externalDependencyType;
                    if (Enum.TryParse(pair.Key, out externalDependencyType))
                    {
                        if (Enum.IsDefined(typeof(ExternalDependencyType), externalDependencyType))
                        {
                            // Value가 false(미사용)인지 확인
                            if(pair.Value == false)
                            {
                                removeDependenciesXml(pair.Key);
                            }
                        }
                    }
                }
            }          
            else
            {
                Debug.Log(String.Format("[ExternalDependencyLoader] removeNotUseDepXmlFromJson, not exist jsonSaveFile"));
            }
        }

        // HIVESDK_*Dependencies.xml 삭제
        private static void removeDependenciesXml(string saveDataProviderName)
        {
            Debug.Log(String.Format("[ExternalDependencyLoader] removeDependenciesXml"));

            DirectoryInfo editorDirInfo = new DirectoryInfo(editorPath);

            // ExternalDependencyType Enum 순회
            foreach(ExternalDependencyType t in Enum.GetValues(typeof(ExternalDependencyType)))
            {
                // 'Xml Element 이름 == Enum 이름' 이면
                if(saveDataProviderName.Equals(Enum.GetName(t.GetType(), t)))
                {
                    // /editor 경로 순회
                    foreach(FileInfo f in editorDirInfo.GetFiles())
                    {
                        // Enum Description 및 파일이름 조합 찾아서 해당 파일 제거
                        if(f.Name.Contains(GetEnumDescription(t) + "Dependencies.xml"))
                        {
                            Debug.Log(String.Format("[ExternalDependencyLoader] removeDependenciesXml, remove : ~" + GetEnumDescription(t) + "Dependencies.xml"));
                            f.Delete(); // .xml 및 .meta 제거
                        }
                    }
                }
            }
        }

        // 파일 삭제
        private static void removeFile(string path)
        {
            Debug.Log(String.Format("[ExternalDependencyLoader] removeFile"));

            if (File.Exists(path))
            {
                try
                {
                    File.Delete(path);
                    Debug.Log(String.Format("[ExternalDependencyLoader] removeFile, path : " + path));
                }
                catch (Exception e)
                {
                    Debug.Log(String.Format("[ExternalDependencyLoader] removeFile, File.Delete({0}) Exception. \n {1}", path, e.ToString()));
                }
            }
        }

        // Enum의 Description 값 획득
        private static string GetEnumDescription(Enum value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name == null)
            {
                return null;
            }
            else
            {
                FieldInfo field = type.GetField(name);
                if (field == null)
                    return name;
                else
                {
                    DescriptionAttribute attr = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attr == null)
                        return name;
                    else
                        return attr.Description;
                }
            }
        }
    }
}
