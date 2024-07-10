namespace UnityEditor.HiveEditor {
    
    using System.IO;
    using System.Collections.Generic;
    using UnityEngine;

    #if UNITY_IOS
    using UnityEditor.iOS;
    using UnityEditor.iOS.Xcode;

    // Unity CapabilityManager 게임센터 추가 불가능한 버그로 마지막에 Entitlements 파일을 쓰고 난 후 직접 읽어 추가한다.
    public class HiveEntitlementsModifier
    {
        // Entltitlement 파일 경로
        private string plistPath;
        // Entitlement 파일 이름 (확장자 포함)
        private string entitlementsFileName;
        // Entitlement 파싱한  데이터
        private PlistElementDict plistElementDict;
        private PlistDocument plistDocument;

        public HiveEntitlementsModifier(string buildPath, string entitlementsFileName) {
            this.entitlementsFileName = entitlementsFileName;
            // Read Entitlements
            this.plistPath = buildPath + "/" + entitlementsFileName;

            this.plistDocument = new PlistDocument();
            this.plistDocument.ReadFromFile(plistPath);
            this.plistElementDict = this.plistDocument.root;
        }

        public void AddGameCenter() {
            this.plistElementDict.SetBoolean("com.apple.developer.game-center", true);
            File.WriteAllText(this.plistPath, this.plistDocument.WriteToString());
        }
    }
    #endif
}