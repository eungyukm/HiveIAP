/**
 * @file    ExternalDependencyEditor.cs
 * 
 * @author  disker
 * @date    2020-2024
 * @copyright Copyright © Com2uS Platform Corporation. All Right Reserved.
 * @defgroup Hive.Unity.Editor
 * @{
 * @brief HIVE External Dependency EditorWindow <br/><br/>
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.IO;
using System.ComponentModel;
using System.Reflection;

namespace Hive.Unity.Editor
{
    using ExternalDependencyDictionary = Dictionary<ExternalDependencyType, bool>;
    using ExternalDependencySerializableDictionary = SerializableDictionary<string, bool>;

    public class ExternalDependencyEditor : EditorWindow
    {
        // Layout Option
        private static int editorWidth = 420;
        private static int questionBtnMargin = 25;
        private GUILayoutOption[] labelOption = {GUILayout.Width(220), GUILayout.ExpandWidth(false)}; 
        private GUILayoutOption[] labelAndActionOption = {GUILayout.Width(60),GUILayout.ExpandWidth(false)};
        private GUILayoutOption[] helpBtnOption = {GUILayout.Width(20),GUILayout.ExpandWidth(false)};
        private GUILayoutOption[] filterOption = {GUILayout.Width(180),GUILayout.ExpandWidth(false)};
        private GUILayoutOption[] titleLabelOptions = {GUILayout.Width(135), GUILayout.Height(50), GUILayout.ExpandWidth(true)};
        private GUILayoutOption[] commentLabelOptions = {GUILayout.Width(135), GUILayout.Height(35), GUILayout.ExpandWidth(true)};
        private GUILayoutOption[] editorMainBtnOption = {GUILayout.Height(35)};

        
        [SerializeField]
        private Vector2 scrollPos = Vector2.zero;


        private ExternalDependencyDictionary externalDependencyDictionary;

        // Help Url 
        private const string developerPageHelpUrl = "https://developers.withhive.com/";
        private const string hiveConfigurationHelpUrl = "https://developers.withhive.com/dev4/porting-building-hive/configuration/";
        private const string idpHelpUrl = "https://developers.withhive.com/dev4/authv4/getting-started/#v4-idplist";
        private const string iapHelpUrl = "https://developers.withhive.com/dev4/billing/getting-started/#supported-features";
        private const string pushHelpUrl = "https://developers.withhive.com/dev4/notification/getting-started/";
        private const string analyticsHelpUrl = "https://developers.withhive.com/dev4/analytics/getting-started/";

        // OptionGroup
        private bool showGroupHiveModule = true;
        private bool showGroupIdp = true;
        private bool showGroupMarket = true;
        private bool showGroupAnalytics = true;
        private bool showGroupPush = true;

        // Hive Module (Label)
        private static GUIContent hivePromotionLabel = new GUIContent("Promotion", "Promotion 사용 여부 설정 (true, false)");
        private static GUIContent googleInAppReviewLabel = new GUIContent("     *Google InAppReview", "Google InAppReview 사용 여부 설정 (true, false)");
        private static GUIContent hiveDeviceManagementLabel = new GUIContent("Device Management", "DeviceManagement 사용 여부 설정 (true, false)");
        private static GUIContent hivePealNameVerificationLabel = new GUIContent("Real Name Verification", "RealNameVerification 사용 여부 설정 (true, false)");
        private static GUIContent herculesLabel = new GUIContent("Hercules", "Hercules 사용 여부 설정 (true, false)");
        private static GUIContent recaptchaLabel = new GUIContent("reCAPTCHA", "reCAPTCHA 사용 여부 설정 (true, false)");
        private static GUIContent dataStoreLabel = new GUIContent("DataStore", "DataStore 사용 여부 설정 (true, false)");
        private static GUIContent googleInAppUpdateLabel = new GUIContent("Google InAppUpdate", "Google InAppUpdate 사용 여부 설정 (true, false)");
        private static GUIContent analyticsConsentModeLabel = new GUIContent("Analytics Consent-Mode", "Analytics Consent-Mode 사용 여부 설정 (true, false)");

        // Idp (Enum, Label)
        // private enum IdpFacebook
        // {
        //     NotUse,
        //     Facebook,
        //     FacebookCloud
        // }

        // private IdpFacebook idpFacebookType
        // {
        //     get {
        //         bool useFacebook = externalDependencyDictionary[ExternalDependencyType.Facebook];
        //         bool useFacebookCloud = externalDependencyDictionary[ExternalDependencyType.FacebookCloud];

        //         if(useFacebook) {
        //             return IdpFacebook.Facebook;
        //         } else {
        //             if(useFacebookCloud) {
        //                 return IdpFacebook.FacebookCloud;
        //             } else{
        //                 return IdpFacebook.NotUse;
        //             }
        //         }
        //     }
        //     set {
        //         if(value == IdpFacebook.NotUse) {
        //             externalDependencyDictionary[ExternalDependencyType.Facebook] = false;
        //             externalDependencyDictionary[ExternalDependencyType.FacebookCloud] = false;
        //         } else if(value == IdpFacebook.Facebook) {
        //             externalDependencyDictionary[ExternalDependencyType.Facebook] = true;
        //             externalDependencyDictionary[ExternalDependencyType.FacebookCloud] = false;
        //         } else {
        //             externalDependencyDictionary[ExternalDependencyType.Facebook] = false;
        //             externalDependencyDictionary[ExternalDependencyType.FacebookCloud] = true;
        //         }
        //     }
        // }

        private static GUIContent googleSignInLabel = new GUIContent("Google SignIn", "Google SignIn 사용 여부 설정 (true, false)");
        private static GUIContent googlePlayGamesLabel = new GUIContent("Google Play Games", "Google Play Games 사용 여부 설정 (true, false)");
        private static GUIContent facebookLabel = new GUIContent("Facebook", "Facebook 사용 여부 설정 (true, false)");
        private static GUIContent facebookCloudLabel = new GUIContent("     *Facebook Cloud", "Facebook Cloud 사용 여부 설정 (true, false)");
        private static GUIContent appleGameCenterLabel = new GUIContent("Apple GameCenter", "Apple GameCenter 사용 여부 설정 (true, false)");
        private static GUIContent appleSignInLabel = new GUIContent("Apple SignIn", "Apple SignIn 사용 여부 설정 (true, false)");
        private static GUIContent lineLabel = new GUIContent("Line", "Line 사용 여부 설정 (true, false)");
        private static GUIContent vkLabel = new GUIContent("VK", "VK 사용 여부 설정 (true, false)");
        private static GUIContent qqLabel = new GUIContent("QQ", "QQ 사용 여부 설정 (true, false)");
        private static GUIContent wechaLabel = new GUIContent("Wechat", "Wechat 사용 여부 설정 (true, false)");
        private static GUIContent weverseLabel = new GUIContent("Weverse", "Weverse 사용 여부 설정 (true, false)");
        private static GUIContent hiveMembershipLabel = new GUIContent("Hive Membership", "HiveMembership 사용 여부 설정 (true, false)");
        private static GUIContent hiveGuestLabel = new GUIContent("Hive Guest", "HiveGuest 사용 여부 설정 (true, false)");
        private static GUIContent huaweiLabel = new GUIContent("Huawei", "Huawei 사용 여부 설정 (true, false)");

        // Push (Label)
        private static GUIContent pushGoogleFcmLabel = new GUIContent("Google FCM", "Google FCM 사용 여부 설정 (true, false)");
        private static GUIContent pushAppleLabel = new GUIContent("Apple APNs", "Apple APNs 사용 여부 설정 (included)");
        private static GUIContent pushFacebookCloudA2uLabel = new GUIContent("Facebook Cloud A2U", "Facebook Cloud A2U 사용 여부 설정 (true, false)");
        private static GUIContent pushAmazonADMLabel = new GUIContent("Amazon ADM", "Amazon ADM 사용 여부 설정 (true, false)");

        // Market (Label)
        private static GUIContent androidMarketGoogleLabel = new GUIContent("Google PlayStore", "Google PlayStore 사용 여부 설정 (true, false)");
        private static GUIContent iOSMarketAppleLabel = new GUIContent("Apple AppStore", "Apple AppStore 사용 여부 설정 (true, false)");
        private static GUIContent androidMarketOneStoreLabel = new GUIContent("OneStore", "OneStore 사용 여부 설정 (true, false)");
        private static GUIContent androidMarketAmazonLabel = new GUIContent("Amazon AppStore", "Amazon AppStore 사용 여부 설정 (true, false)");
        private static GUIContent androidMarketLebiLabel = new GUIContent("Lebi", "Lebi 사용 여부 설정 (true, false)");
        private static GUIContent androidMarketHiveStoreLabel = new GUIContent("Hive Store", "Hive Store 사용 여부 설정 (true, false)");
        private static GUIContent androidMarketFacebookCloudLabel = new GUIContent("Facebook Cloud", "Facebook Cloud 사용 여부 설정 (true, false)");
        private static GUIContent androidMarketSamsungLabel = new GUIContent("Samsung GalaxyStore", "Samsung GalaxyStore 사용 여부 설정 (true, false)");
        private static GUIContent androidMarketHuaweiLabel = new GUIContent("Huawei AppGallery", "Huawei AppGallery 사용 여부 설정 (true, false)");

        // Analytics (Label)
        private static GUIContent adjustLabel = new GUIContent("Adjust", "Adjust 사용 여부 설정 (true, false)");
        private static GUIContent appsFlyerLabel = new GUIContent("AppsFlyer", "AppsFlyer 사용 여부 설정 (true, false)");
        private static GUIContent singularLabel = new GUIContent("Singular", "Singular 사용 여부 설정 (true, false)");
        private static GUIContent firebaseLabel = new GUIContent("Firebase", "Firebase 사용 여부 설정 (true, false)");



        [MenuItem("Hive/Hive Dependencies (ExternalDependency)")]
        public static void create()
        {
            var editor = (ExternalDependencyEditor)EditorWindow.GetWindow(typeof(ExternalDependencyEditor), true, "HiveDependencies");
            editor.Initialize();
            editor.Show();
        }

        public void Initialize()
        {
            minSize = new Vector2(editorWidth, editorWidth * 2);
            position = new Rect(UnityEngine.Screen.width / 3, UnityEngine.Screen.height / 3, minSize.x, minSize.y);

            externalDependencyDictionary = ExternalDependencyDictionaryManager.LoadExternalDependencyDictionary();
        }

        public static bool isShowing() {
            if(EditorWindow.HasOpenInstances<ExternalDependencyEditor>())
            {
                return true;
            }
            return false;
        }

        private void setDefaultMarkWithLabel(GUIContent label, string linkUrl)
        {
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField(label, labelOption);
            if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                Application.OpenURL(linkUrl);
            }

            EditorGUILayout.LabelField(new GUIContent("included", "HiveSDK 기본 포함"), labelOption);
            EditorGUILayout.EndHorizontal();
        }

        void DrawUILine(Color color, int thickness = 1, int padding = 10)
        {
            Rect r = EditorGUILayout.GetControlRect(GUILayout.Height(padding+thickness));
            r.height = thickness;
            r.y+=padding/2;
            r.x-=2;
            r.width +=6;
            EditorGUI.DrawRect(r, color);
        }

        GUIStyle getEditorTitleStyle()
        {
            GUIStyle titleStyle = new GUIStyle();
            titleStyle.fontSize = 30;
            titleStyle.normal.textColor = Color.white;
            return titleStyle;
        }

        GUIStyle getFolderTextStyle()
        {
            GUIStyle folderStyle = new GUIStyle(EditorStyles.foldout);
            folderStyle.normal.textColor = Color.white;
            folderStyle.alignment = TextAnchor.MiddleLeft;
            return folderStyle;
        }

        GUIStyle getTextStyle(string type)
        {
            // ios or android
            GUIStyle osStyle = new GUIStyle();
            if(type.Equals("ios"))
            {
                osStyle.normal.textColor = Color.cyan;
            }
            else if(type.Equals("android"))
            {
                osStyle.normal.textColor = Color.green;
            }
            
            osStyle.alignment = TextAnchor.MiddleLeft;
            return osStyle;
        }

        GUIStyle getQuestionBtnStyle()
        {
            GUIStyle btnStyle = EditorStyles.miniButton;
            btnStyle.alignment = TextAnchor.MiddleCenter;
            btnStyle.normal.textColor = Color.gray;
            return btnStyle;
        }

        float getFloatFromToogle(bool value) {
            if(value)
                return 1f;
            else
                return 0;
        }

        void OnGUI()
        {
            scrollPos = EditorGUILayout.BeginScrollView(scrollPos);

            // OS 구분된 기능 설명
            EditorGUILayout.BeginVertical();

            EditorGUILayout.LabelField("  Hive Dependencies", getEditorTitleStyle(), titleLabelOptions);

            EditorGUILayout.LabelField("    Hive Dependenices settings are common to Android and iOS,\n    and if it is an OS-specific function, they are color coded below.", commentLabelOptions);
            EditorGUILayout.LabelField("    (Hive Dependenices 설정은 Android, iOS 공통이며\n    OS 단일 기능은 각각 아래 색상으로 구분되어 있습니다.)\n", commentLabelOptions);
            EditorGUILayout.LabelField("    Android", getTextStyle("android"), labelOption);
            EditorGUILayout.LabelField("    iOS", getTextStyle("ios"), labelOption);
            EditorGUILayout.EndVertical();

            DrawUILine(Color.grey);

            // Hive Module
            EditorGUILayout.BeginVertical();
            EditorGUI.indentLevel++;
            EditorGUILayout.EndVertical();

            EditorGUILayout.BeginVertical();
            this.showGroupHiveModule = EditorGUILayout.Foldout(this.showGroupHiveModule, "Hive Module Settings", getFolderTextStyle());
            if(this.showGroupHiveModule)
            {
                EditorGUI.indentLevel++;

                // HivePromotion
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(hiveConfigurationHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(hivePromotionLabel, labelOption);
                externalDependencyDictionary[ExternalDependencyType.HivePromotion] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.HivePromotion], labelAndActionOption);
                if(!externalDependencyDictionary[ExternalDependencyType.HivePromotion])
                {
                    externalDependencyDictionary[ExternalDependencyType.GoogleInAppReview] = false;
                }
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // GoogleInAppReview
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(hiveConfigurationHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(googleInAppReviewLabel, getTextStyle("android"), labelOption);
                externalDependencyDictionary[ExternalDependencyType.GoogleInAppReview] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.GoogleInAppReview], labelAndActionOption);
                if(externalDependencyDictionary[ExternalDependencyType.GoogleInAppReview])
                {
                    externalDependencyDictionary[ExternalDependencyType.HivePromotion] = true;
                }

                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // HiveDeviceManagement
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(hiveConfigurationHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(hiveDeviceManagementLabel, labelOption);
                externalDependencyDictionary[ExternalDependencyType.HiveDeviceManagement] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.HiveDeviceManagement], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // HiveRealNameVerification
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(hiveConfigurationHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(hivePealNameVerificationLabel, labelOption);
                externalDependencyDictionary[ExternalDependencyType.HiveRealNameVerification] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.HiveRealNameVerification], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // Hercules
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(hiveConfigurationHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(herculesLabel, labelOption);
                externalDependencyDictionary[ExternalDependencyType.Hercules] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.Hercules], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // Recaptcha
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(hiveConfigurationHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(recaptchaLabel, labelOption);
                externalDependencyDictionary[ExternalDependencyType.Recaptcha] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.Recaptcha], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // DataStore
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(hiveConfigurationHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(dataStoreLabel, labelOption);
                externalDependencyDictionary[ExternalDependencyType.DataStore] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.DataStore], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // GoogleInAppUpdate
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(hiveConfigurationHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(googleInAppUpdateLabel, getTextStyle("android"), labelOption);
                externalDependencyDictionary[ExternalDependencyType.GoogleInAppUpdate] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.GoogleInAppUpdate], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // AnalyticsConsentMode
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(hiveConfigurationHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(analyticsConsentModeLabel, labelOption);
                externalDependencyDictionary[ExternalDependencyType.AnalyticsConsentMode] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.AnalyticsConsentMode], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                EditorGUI.indentLevel--;               
            }
            EditorGUI.indentLevel--;
            EditorGUILayout.EndVertical();

            DrawUILine(Color.grey);

            // Idp
            EditorGUILayout.BeginVertical();
            EditorGUI.indentLevel++;
            EditorGUILayout.EndVertical();

            EditorGUILayout.BeginVertical();
            this.showGroupIdp = EditorGUILayout.Foldout(this.showGroupIdp, "Auth Settings");
            if(this.showGroupIdp)
            {
                EditorGUI.indentLevel++;

                // HiveMembership
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(idpHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(hiveMembershipLabel, labelOption);
                externalDependencyDictionary[ExternalDependencyType.HiveMembership] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.HiveMembership], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // Google SignIn
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(idpHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(googleSignInLabel, labelOption);
                externalDependencyDictionary[ExternalDependencyType.Google] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.Google], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // Google PlayGames
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(idpHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(googlePlayGamesLabel, getTextStyle("android"), labelOption);
                externalDependencyDictionary[ExternalDependencyType.GooglePlayGames] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.GooglePlayGames], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // Facebook (Facebook, FacebookCloud, not use)
                // EditorGUILayout.BeginHorizontal();
                // GUILayout.Space(questionBtnMargin);
                // if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption))
                // {
                //     Application.OpenURL(idpHelpUrl);
                // }
                // EditorGUI.indentLevel--;
                // EditorGUILayout.LabelField(facebookLabel, labelOption);
                // idpFacebookType = (IdpFacebook)EditorGUILayout.EnumPopup(idpFacebookType, filterOption);
                // EditorGUI.indentLevel++;
                // EditorGUILayout.EndVertical();

                // Facebook
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(idpHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(facebookLabel, labelOption);
                externalDependencyDictionary[ExternalDependencyType.Facebook] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.Facebook], labelAndActionOption);
                if(externalDependencyDictionary[ExternalDependencyType.Facebook])
                {
                    externalDependencyDictionary[ExternalDependencyType.FacebookCloud] = false;
                    externalDependencyDictionary[ExternalDependencyType.MarketFacebookCloud] = false;
                    externalDependencyDictionary[ExternalDependencyType.PushFacebookCloudA2u] = false;
                }
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // FacebookCloud
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(idpHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(facebookCloudLabel, getTextStyle("android"), labelOption);
                externalDependencyDictionary[ExternalDependencyType.FacebookCloud] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.FacebookCloud], labelAndActionOption);
                if(externalDependencyDictionary[ExternalDependencyType.FacebookCloud])
                {
                    externalDependencyDictionary[ExternalDependencyType.Facebook] = false;
                    externalDependencyDictionary[ExternalDependencyType.MarketFacebookCloud] = true;
                    externalDependencyDictionary[ExternalDependencyType.PushFacebookCloudA2u] = true;
                } else {
                    externalDependencyDictionary[ExternalDependencyType.MarketFacebookCloud] = false;
                    externalDependencyDictionary[ExternalDependencyType.PushFacebookCloudA2u] = false;
                }
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // Apple GameCenter
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(idpHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(appleGameCenterLabel, getTextStyle("ios"), labelOption);
                externalDependencyDictionary[ExternalDependencyType.Apple] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.Apple], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // Apple SignIn
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(idpHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(appleSignInLabel, labelOption);
                externalDependencyDictionary[ExternalDependencyType.AppleSignIn] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.AppleSignIn], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // Line
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(idpHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(lineLabel, labelOption);
                externalDependencyDictionary[ExternalDependencyType.Line] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.Line], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // VK
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(idpHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(vkLabel, labelOption);
                externalDependencyDictionary[ExternalDependencyType.VK] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.VK], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // QQ
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(idpHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(qqLabel, labelOption);
                externalDependencyDictionary[ExternalDependencyType.QQ] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.QQ], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // Wechat
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(idpHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(wechaLabel, labelOption);
                externalDependencyDictionary[ExternalDependencyType.Wechat] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.Wechat], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // Weverse
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(idpHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(weverseLabel, labelOption);
                externalDependencyDictionary[ExternalDependencyType.Weverse] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.Weverse], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // setDefaultMarkWithLabel(hiveGuestLabel, idpHelpUrl);    // default 셋팅 예

                // Huawei (Global)
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(idpHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(huaweiLabel, getTextStyle("android"), labelOption);
                externalDependencyDictionary[ExternalDependencyType.Huawei] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.Huawei], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();
                // about Huawei agconnect-services
                if(EditorGUILayout.BeginFadeGroup(getFloatFromToogle(externalDependencyDictionary[ExternalDependencyType.Huawei])))
                {
                    EditorGUI.indentLevel++;
                    EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.LabelField("(Huawei) Add the 'agconnect-services.json' to your app.", commentLabelOptions);
                    EditorGUILayout.EndHorizontal();
                    EditorGUI.indentLevel--;
                }
                else {
                    // nothing to do 
                }
                EditorGUILayout.EndFadeGroup();

                EditorGUI.indentLevel--;
            }
            EditorGUI.indentLevel--;
            EditorGUILayout.EndVertical();

            DrawUILine(Color.grey);

            // Push
            EditorGUILayout.BeginVertical();
            EditorGUI.indentLevel++;
            EditorGUILayout.EndVertical();

            EditorGUILayout.BeginVertical();
            this.showGroupPush = EditorGUILayout.Foldout(this.showGroupPush, "Push Settings");
            if(this.showGroupPush)
            {
                EditorGUI.indentLevel++;

                // Google FCM
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(pushHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(pushGoogleFcmLabel, getTextStyle("android"), labelOption);
                externalDependencyDictionary[ExternalDependencyType.PushGoogleFcm] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.PushGoogleFcm], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // Apple APNs
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(pushHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(pushAppleLabel, getTextStyle("ios"), labelOption);
                EditorGUILayout.LabelField("included", labelOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // Facebook Cloud A2U
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(pushHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(pushFacebookCloudA2uLabel, getTextStyle("android"), labelOption);
                externalDependencyDictionary[ExternalDependencyType.PushFacebookCloudA2u] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.PushFacebookCloudA2u], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // Amazon ADM
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(pushHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(pushAmazonADMLabel, getTextStyle("android"), labelOption);
                externalDependencyDictionary[ExternalDependencyType.PushAmazonAdm] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.PushAmazonAdm], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                EditorGUI.indentLevel--;
            }
            EditorGUI.indentLevel--;
            EditorGUILayout.EndVertical();

            DrawUILine(Color.grey);

            // Market
            EditorGUILayout.BeginVertical();
            EditorGUI.indentLevel++;
            EditorGUILayout.EndVertical();

            EditorGUILayout.BeginVertical();
            this.showGroupMarket = EditorGUILayout.Foldout(this.showGroupMarket, "Market Settings");
            if(this.showGroupMarket)
            {
                EditorGUI.indentLevel++;

                // Google PlayStore
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(iapHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(androidMarketGoogleLabel, getTextStyle("android"), labelOption);
                externalDependencyDictionary[ExternalDependencyType.MarketGoogle] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.MarketGoogle], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // Apple AppStore
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(iapHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(iOSMarketAppleLabel, getTextStyle("ios"), labelOption);
                externalDependencyDictionary[ExternalDependencyType.MarketApple] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.MarketApple], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // OneStore
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(iapHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(androidMarketOneStoreLabel, getTextStyle("android"), labelOption);
                externalDependencyDictionary[ExternalDependencyType.MarketOneStore] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.MarketOneStore], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // Amazon AppStore
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(iapHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(androidMarketAmazonLabel, getTextStyle("android"), labelOption);
                externalDependencyDictionary[ExternalDependencyType.MarketAmazon] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.MarketAmazon], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // Lebi
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(iapHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(androidMarketLebiLabel, getTextStyle("android"), labelOption);
                externalDependencyDictionary[ExternalDependencyType.MarketLebi] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.MarketLebi], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // Hive Store
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(iapHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(androidMarketHiveStoreLabel, getTextStyle("android"), labelOption);
                externalDependencyDictionary[ExternalDependencyType.MarketHiveStore] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.MarketHiveStore], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // Facebook Cloud
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(iapHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(androidMarketFacebookCloudLabel, getTextStyle("android"), labelOption);
                externalDependencyDictionary[ExternalDependencyType.MarketFacebookCloud] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.MarketFacebookCloud], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // Samsung GalaxyStore
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(iapHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(androidMarketSamsungLabel, getTextStyle("android"), labelOption);
                externalDependencyDictionary[ExternalDependencyType.MarketSamsung] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.MarketSamsung], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // Huawei AppGallery
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(iapHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(androidMarketHuaweiLabel, getTextStyle("android"), labelOption);
                externalDependencyDictionary[ExternalDependencyType.MarketHuawei] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.MarketHuawei], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                EditorGUI.indentLevel--;
            }
            EditorGUI.indentLevel--;
            EditorGUILayout.EndVertical();

            DrawUILine(Color.grey);

            // Analytics
            EditorGUILayout.BeginVertical();
            EditorGUI.indentLevel++;
            EditorGUILayout.EndVertical();

            EditorGUILayout.BeginVertical();
            this.showGroupAnalytics = EditorGUILayout.Foldout(this.showGroupAnalytics, "Analytics Settings");
            if(this.showGroupAnalytics)
            {
                EditorGUI.indentLevel++;

                // Adjust
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(analyticsHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(adjustLabel, labelOption);
                externalDependencyDictionary[ExternalDependencyType.Adjust] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.Adjust], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // AppsFlyer
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(analyticsHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(appsFlyerLabel, labelOption);
                externalDependencyDictionary[ExternalDependencyType.AppsFlyer] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.AppsFlyer], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // Singular
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(analyticsHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(singularLabel, labelOption);
                externalDependencyDictionary[ExternalDependencyType.Singular] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.Singular], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();

                // Firebase
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(questionBtnMargin);
                if(GUILayout.Button("?", getQuestionBtnStyle(), helpBtnOption)) {
                    Application.OpenURL(analyticsHelpUrl);
                }
                EditorGUI.indentLevel--;
                EditorGUILayout.LabelField(firebaseLabel, labelOption);
                externalDependencyDictionary[ExternalDependencyType.Firebase] = EditorGUILayout.Toggle(externalDependencyDictionary[ExternalDependencyType.Firebase], labelAndActionOption);
                EditorGUI.indentLevel++;
                EditorGUILayout.EndHorizontal();
                // about Firebase google-services
                if(EditorGUILayout.BeginFadeGroup(getFloatFromToogle(externalDependencyDictionary[ExternalDependencyType.Firebase])))
                {
                    EditorGUI.indentLevel++;
                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("(Firebase) Add the 'google-services.json' to your app.", commentLabelOptions);
                EditorGUILayout.EndHorizontal();
                EditorGUI.indentLevel--;
                }
                else {
                    // nothing to do 
                }
                EditorGUILayout.EndFadeGroup();

                EditorGUI.indentLevel--;
            }
            EditorGUI.indentLevel--;
            GUILayout.Space(20);

            // Scroll 영역 종료
            EditorGUILayout.EndScrollView();

            EditorGUILayout.EndVertical();

            EditorGUILayout.BeginVertical();

            // OK button
            bool okButton = GUILayout.Button("Save", editorMainBtnOption);

            // Reset to Defaults button
            if (GUILayout.Button("Reset", editorMainBtnOption))
            {
                ExternalDependencyDictionaryManager.Reset(ref externalDependencyDictionary);
            }

            // Cancel button
            bool closeButton = GUILayout.Button("Cancel", editorMainBtnOption);   
            closeButton |= okButton;
            // OK button event
            if (okButton)
            {
                SetupEDM4UExternalDependency();
                SetupIncludedExternalDependency();
                ExternalDependencyDictionaryManager.SaveExternalDependencyDictionary(ref externalDependencyDictionary);
                AssetDatabase.Refresh();

                ResolveEDM4U();
            }
            // Cancel button event
            if (closeButton) Close();

            EditorGUILayout.EndVertical();
        }

        private void SetupEDM4UExternalDependency()
        {
            string editorPath = Path.Combine(Application.dataPath, "Hive_SDK_v4/Editor");
            string dependenciesPath = Path.Combine(Application.dataPath, "Hive_SDK_v4/Dependencies");

            DirectoryCopy(dependenciesPath, editorPath);

            DirectoryInfo editorDirInfo = new DirectoryInfo(editorPath);
            foreach (ExternalDependencyType t in Enum.GetValues(typeof(ExternalDependencyType)))    // enum 순회
            {
                if (externalDependencyDictionary[t])
                    continue;

                foreach (FileInfo f in editorDirInfo.GetFiles())
                {
                    // 관련된 xml 파일을 찾을 때 Enum Description string value를 포함한 파일을 찾음
                    if (f.Name.Contains(GetEnumDescription(t) + "Dependencies.xml"))
                        f.Delete();
                }
            }
        }

        private void SetupIncludedExternalDependency()
        {
            SetupIncludedExternalDependencyForAndroid();
            SetupIncludedExternalDependencyForIOS();
        }

        private void SetupIncludedExternalDependencyForAndroid()
        {
            var libPath = "Assets/Hive_SDK_v4/Plugins/Android/libs";

            if (!Directory.Exists(libPath))
            {
                Directory.CreateDirectory(libPath);
            }

            DirectoryInfo libDirInfo = new DirectoryInfo(libPath);
            FileInfo[] libFileInfoes = libDirInfo.GetFiles();
            if (libFileInfoes == null || libFileInfoes.Length == 0)
            {
                Debug.Log(libPath + "\n" + "FileInfo[] is null or empty");
                return;
            }

            foreach (FileInfo f in libFileInfoes)
            {
                if (f.Extension.ToLower().Equals(".meta"))
                    continue;

                PluginImporter plugin = PluginImporter.GetAtPath(libPath + "/" + f.Name) as PluginImporter;

                // libPath 경로의 라이브러리를 디펜던시 여부에 따라 플러그인 임포트 처리
                if (f.Name.Contains("open_sdk_"))
                {
                    bool enable = externalDependencyDictionary[ExternalDependencyType.QQ];
                    plugin.SetCompatibleWithAnyPlatform(false);
                    plugin.SetCompatibleWithEditor(false);
                    plugin.SetCompatibleWithPlatform(BuildTarget.Android, enable);
                }
                else if (f.Name.Contains("mid-sdk-"))
                {
                    bool enable = externalDependencyDictionary[ExternalDependencyType.QQ];
                    plugin.SetCompatibleWithAnyPlatform(false);
                    plugin.SetCompatibleWithEditor(false);
                    plugin.SetCompatibleWithPlatform(BuildTarget.Android, enable);
                }
                else if (f.Name.Contains("mta-sdk-"))
                {
                    bool enable = externalDependencyDictionary[ExternalDependencyType.QQ] || externalDependencyDictionary[ExternalDependencyType.Wechat];
                    plugin.SetCompatibleWithAnyPlatform(false);
                    plugin.SetCompatibleWithEditor(false);
                    plugin.SetCompatibleWithPlatform(BuildTarget.Android, enable);
                }

                try
                {
                    plugin.SaveAndReimport();
                }
                catch (Exception ex)
                {
                    Debug.Log(String.Format("{0} is not allocated as PluginImporter. \n {1}", f.Name, ex.ToString()));
                }   
            }
        }

        private void SetupIncludedExternalDependencyForIOS() {
            var frameworkPath = "Assets/Hive_SDK_v4/Plugins/iOS/framework";

            if (!Directory.Exists(frameworkPath))
            {
                Directory.CreateDirectory(frameworkPath);
            }

            DirectoryInfo frameworkDirInfo = new DirectoryInfo(frameworkPath);
            DirectoryInfo[] frameworkDirInfoes = frameworkDirInfo.GetDirectories();
            if (frameworkDirInfoes == null || frameworkDirInfoes.Length == 0)
            {
                Debug.Log(frameworkPath + "\n" + "DirectoryInfo[] is null or empty");
                return;
            }

            foreach (DirectoryInfo d in frameworkDirInfoes)
            {
                PluginImporter plugin = PluginImporter.GetAtPath(frameworkPath + "/" + d.Name) as PluginImporter;

                if (d.Name.Equals("WXApi.framework"))
                {
                    bool enable = externalDependencyDictionary[ExternalDependencyType.Wechat];
                    plugin.SetCompatibleWithAnyPlatform(false);
                    plugin.SetCompatibleWithEditor(false);
                    plugin.SetCompatibleWithPlatform(BuildTarget.iOS, enable);

                }
                else if (d.Name.Equals("TencentOpenAPI.framework"))
                {
                    bool enable = externalDependencyDictionary[ExternalDependencyType.QQ];
                    plugin.SetCompatibleWithAnyPlatform(false);
                    plugin.SetCompatibleWithEditor(false);
                    plugin.SetCompatibleWithPlatform(BuildTarget.iOS, enable);
                }
                else if (d.Name.Equals("VKSdk.framework"))
                {
                    bool enable = externalDependencyDictionary[ExternalDependencyType.VK];
                    plugin.SetCompatibleWithAnyPlatform(false);
                    plugin.SetCompatibleWithEditor(false);
                    plugin.SetCompatibleWithPlatform(BuildTarget.iOS, enable);
                }
                else if (d.Name.Equals("ProviderAdapter.framework"))
                {
                    plugin.SetCompatibleWithAnyPlatform(false);
                    plugin.SetCompatibleWithEditor(false);
                    plugin.SetCompatibleWithPlatform(BuildTarget.iOS, true);
                }

                /*
                    HIVE 제공 framework
                */
                else if (d.Name.Contains("ProviderWechat"))
                {
                    bool enable = externalDependencyDictionary[ExternalDependencyType.Wechat];
                    plugin.SetCompatibleWithAnyPlatform(false);
                    plugin.SetCompatibleWithEditor(false);
                    plugin.SetCompatibleWithPlatform(BuildTarget.iOS, enable);
                }
                else if (d.Name.Contains("ProviderVK"))
                {
                    bool enable = externalDependencyDictionary[ExternalDependencyType.VK];
                    plugin.SetCompatibleWithAnyPlatform(false);
                    plugin.SetCompatibleWithEditor(false);
                    plugin.SetCompatibleWithPlatform(BuildTarget.iOS, enable);
                }
                else if (d.Name.Contains("ProviderSingular"))
                {
                    bool enable = externalDependencyDictionary[ExternalDependencyType.Singular];
                    plugin.SetCompatibleWithAnyPlatform(false);
                    plugin.SetCompatibleWithEditor(false);
                    plugin.SetCompatibleWithPlatform(BuildTarget.iOS, enable);
                }
                else if (d.Name.Contains("ProviderQQ"))
                {
                    bool enable = externalDependencyDictionary[ExternalDependencyType.QQ];
                    plugin.SetCompatibleWithAnyPlatform(false);
                    plugin.SetCompatibleWithEditor(false);
                    plugin.SetCompatibleWithPlatform(BuildTarget.iOS, enable);
                }
                else if (d.Name.Contains("ProviderLine"))
                {
                    bool enable = externalDependencyDictionary[ExternalDependencyType.Line];
                    plugin.SetCompatibleWithAnyPlatform(false);
                    plugin.SetCompatibleWithEditor(false);
                    plugin.SetCompatibleWithPlatform(BuildTarget.iOS, enable);
                }
                else if (d.Name.Contains("ProviderWeverse"))
                {
                    bool enable = externalDependencyDictionary[ExternalDependencyType.Weverse];
                    plugin.SetCompatibleWithAnyPlatform(false);
                    plugin.SetCompatibleWithEditor(false);
                    plugin.SetCompatibleWithPlatform(BuildTarget.iOS, enable);
                }
                else if (d.Name.Contains("ProviderAppsFlyer"))
                {
                    bool enable = externalDependencyDictionary[ExternalDependencyType.AppsFlyer];
                    plugin.SetCompatibleWithAnyPlatform(false);
                    plugin.SetCompatibleWithEditor(false);
                    plugin.SetCompatibleWithPlatform(BuildTarget.iOS, enable);
                }
                else if (d.Name.Contains("ProviderAdjust"))
                {
                    bool enable = externalDependencyDictionary[ExternalDependencyType.Adjust];
                    plugin.SetCompatibleWithAnyPlatform(false);
                    plugin.SetCompatibleWithEditor(false);
                    plugin.SetCompatibleWithPlatform(BuildTarget.iOS, enable);
                }
                else if (d.Name.Contains("ProviderFirebase"))
                {
                    bool enable = externalDependencyDictionary[ExternalDependencyType.Firebase];
                    plugin.SetCompatibleWithAnyPlatform(false);
                    plugin.SetCompatibleWithEditor(false);
                    plugin.SetCompatibleWithPlatform(BuildTarget.iOS, enable);
                }
                else if (d.Name.Contains("HiveRecaptcha"))
                {
                    bool enable = externalDependencyDictionary[ExternalDependencyType.Recaptcha];
                    plugin.SetCompatibleWithAnyPlatform(false);
                    plugin.SetCompatibleWithEditor(false);
                    plugin.SetCompatibleWithPlatform(BuildTarget.iOS, enable);
                }
                else if (d.Name.Contains("Hercules"))
                {
                    bool enable = externalDependencyDictionary[ExternalDependencyType.Hercules];
                    plugin.SetCompatibleWithAnyPlatform(false);
                    plugin.SetCompatibleWithEditor(false);
                    plugin.SetCompatibleWithPlatform(BuildTarget.iOS, enable);
                }
                else if (d.Name.Contains("ProviderApple"))
                {
                    bool enable = externalDependencyDictionary[ExternalDependencyType.Apple];
                    plugin.SetCompatibleWithAnyPlatform(false);
                    plugin.SetCompatibleWithEditor(false);
                    plugin.SetCompatibleWithPlatform(BuildTarget.iOS, enable);
                }
                else if (d.Name.Contains("ProviderHive"))
                {
                    bool enable = externalDependencyDictionary[ExternalDependencyType.HiveMembership];
                    plugin.SetCompatibleWithAnyPlatform(false);
                    plugin.SetCompatibleWithEditor(false);
                    plugin.SetCompatibleWithPlatform(BuildTarget.iOS, enable);
                }

                try
                {
                    plugin.SaveAndReimport();
                }
                catch (Exception ex)
                {
                    Debug.Log(String.Format("{0} is not allocated as PluginImporter. \n {1}", d.Name, ex.ToString()));
                }
            }
        }

        private void setupExternalLibsForAndroid() {

        }

        private void ResolveEDM4U()
        {
#if UNITY_ANDROID
            string mainTemplatePath = Path.Combine(Application.dataPath, "Plugins/Android/mainTemplate.gradle");

            // platfrom Android 설정된 상태에서 mainTemplate.gradle이 존재하지 않은채 Resolve 수행시, 프리징
            if (File.Exists(mainTemplatePath))
            {
                GooglePlayServices.PlayServicesResolver.Resolve(null, true, null);
                GooglePlayServices.PlayServicesResolver.ResolveSync(true);
            }
            else
            {
                Debug.Log("Failed EDM4U Resolve. Please check if the file(Plugins/Android/mainTemplate.gradle) exist.");
            }
#endif
        }

        private bool IsFile(string path, string file)
        {
            string[] files = Directory.GetFiles(path, file);
            return files.Length > 0 ? true : false;
        }

        private void DirectoryCopy(string sourcePath, string destPath)
        {
            DirectoryInfo dir = new DirectoryInfo(sourcePath);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + dir
                );
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                if (file.Name.Contains(".meta"))
                    continue;
                string tempPath = Path.Combine(destPath, file.Name);
                file.CopyTo(tempPath, true);
            }
        }

        private string GetEnumDescription(Enum value)
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