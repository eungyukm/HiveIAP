using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

#if UNITY_EDITOR
public class HivePostProcessEditorIOS : EditorWindow {

    private HivePostProcessSettingIOS setting;
    Vector2 scrollPos;
    const int SCROLL_VIEW_WIDTH = 1000;
    const int SCROLL_VIEW_HEIGHT = 500;
    const float LABEL_WIDTH = 500;
    const int TITLE_FONT_SIZE = 30;
    const float TITLE_WIDH = 300;
    const float TITLE_HEIGHT = 50;

    private HivePostProcessEditorIOS() {
        setting = new HivePostProcessSettingIOS();
    }

    public static void ShowWindow() {
        var window = GetWindow<HivePostProcessEditorIOS>();
        window.titleContent = new GUIContent("Hive PostProcess Editor (IOS)");
        window.Show();
    }

    private void OnGUI() {
        setEditorGUISettings();

        scrollPos = EditorGUILayout.BeginScrollView(scrollPos, GUILayout.Width(SCROLL_VIEW_WIDTH), GUILayout.Height(SCROLL_VIEW_HEIGHT));
        drawCapabilites();
        EditorGUILayout.Space();
        /*
        showGoogleServiceInfoPlist();
        EditorGUILayout.Space();
        */
        EditorGUILayout.EndScrollView();
        drawEndLineButtons();
    }

    private void setEditorGUISettings() {
        EditorGUIUtility.labelWidth = LABEL_WIDTH;
    }

    private void drawCapabilites() {
        drawTitle("Capabilities");
        EditorGUILayout.Space();
        drawHorizontalLine();

        // Capabilites
        setting.isAddPushNotifications = EditorGUILayout.BeginToggleGroup("Push Notifications", setting.isAddPushNotifications);
        setting.isPushNotificationsDevelopment = EditorGUILayout.Toggle("Development Mode", setting.isPushNotificationsDevelopment);
        setting.isPushNotificationsDevelopment = !EditorGUILayout.Toggle("Release Mode", !setting.isPushNotificationsDevelopment);
        EditorGUILayout.EndToggleGroup();
        drawHorizontalLine();

        setting.isAddBackGroundModesRemoteNotifications = EditorGUILayout.Toggle("Background Modes (Remote Notifications)", setting.isAddBackGroundModesRemoteNotifications);
        drawHorizontalLine();
        setting.isAddGameCenter = EditorGUILayout.Toggle("Game Center", setting.isAddGameCenter);
        drawHorizontalLine();
        setting.isAddSignInWithApple = EditorGUILayout.Toggle("Sign in with Apple", setting.isAddSignInWithApple);
        drawHorizontalLine();
        setting.isAddInAppPurchase = EditorGUILayout.Toggle("In-App Purchase", setting.isAddInAppPurchase);
        drawHorizontalLine();

        setting.isAddAssociatedDomains = EditorGUILayout.BeginToggleGroup("Associated Domains", setting.isAddAssociatedDomains);
        string associatedDomainsCountString = setting.associatedDomains.Count.ToString();
        associatedDomainsCountString = EditorGUILayout.TextField ("size", associatedDomainsCountString);
        int associatedDomainsCountInt;
        if (int.TryParse(associatedDomainsCountString, out associatedDomainsCountInt)) {
            var associatedDomains = drawDynamicTextFields(associatedDomainsCountInt, setting.associatedDomains);
            setting.associatedDomains = associatedDomains;
        } else {
            Debug.Log("Input 'size' is wrong. should be Integer type.");
        }
        EditorGUILayout.EndToggleGroup ();
        drawHorizontalLine();
        
    }

    /*
    private void showGoogleServiceInfoPlist() {
        GUILayout.Label(" - Info.plist - ", EditorStyles.boldLabel);
        EditorGUILayout.Space();

        setting.isAddGoogleServiceInfoPlist = EditorGUILayout.BeginToggleGroup("Add GoogleService-Info.plist file to Xcode project", setting.isAddGoogleServiceInfoPlist);
        setting.googleServiceInfoPlistFilePath = EditorGUILayout.TextField("path", setting.googleServiceInfoPlistFilePath);
        EditorGUILayout.EndToggleGroup();
    }
    */

    private void drawEndLineButtons() {
        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Reset")) {
            Debug.Log("Reset settings.");
            setting.reset();
        }
        if (GUILayout.Button("Apply")) {
            Debug.Log("Apply settings.");
            setting.apply();
        }
        EditorGUILayout.EndHorizontal();
    }

    private void drawHorizontalLine() {
        EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
    }

    private void drawTitle(string title) {
        GUI.skin.label.fontSize = TITLE_FONT_SIZE;
        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        GUILayout.Label(title, GUILayout.Width(TITLE_WIDH), GUILayout.Height(TITLE_HEIGHT));
        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
    }

    private List<string> drawDynamicTextFields(int targetSize, List<string> defaultList) {
        var result = new List<string>();
        
        for (int i=0; i<targetSize; i++) {
            if (i >= defaultList.Count) {
                var value = EditorGUILayout.TextField("value_"+i, "");
                result.Add(value);
            } else {
                var value = EditorGUILayout.TextField("value_"+i, defaultList[i]);
                result.Add(value);
            }
        }

        return result;
    }
}
#endif
