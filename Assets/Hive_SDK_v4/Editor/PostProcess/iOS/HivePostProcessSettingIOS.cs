using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using hive;
using MiniJSON;

public class HivePostProcessSettingIOS
{
    private HivePostProcessDefaultSettingIOS defaultSetting;
    private HivePostProcessKey postProcessKey;
    private HivePostProcessFileIOS file;
    // Capabilites
    public bool isAddPushNotifications;
    public bool isPushNotificationsDevelopment;
    public bool isAddBackGroundModesRemoteNotifications;
    public bool isAddSignInWithApple;
    public bool isAddGameCenter;
    public bool isAddInAppPurchase;
    public bool isAddAssociatedDomains;
    public List<string> associatedDomains;
    /*// Info.plist
    public bool isAddGoogleServiceInfoPlist;
    public string googleServiceInfoPlistFilePath;
    */

    public HivePostProcessSettingIOS() {
        defaultSetting = new HivePostProcessDefaultSettingIOS();
        postProcessKey = new HivePostProcessKey();
        file = new HivePostProcessFileIOS();

        load();
    }

    public string toJsonString() {
        var dictionary = this.toDictionary();
        var jsonObj = new JSONObject(dictionary);
        var jsonString = jsonObj.ToString();

        return jsonString;
    }

    public Dictionary<string, string> toDictionary() {
        var dictionary = new Dictionary<string, string>();
        dictionary[postProcessKey.isAddPushNotifications] = this.isAddPushNotifications.ToString();
        dictionary[postProcessKey.isPushNotificationsDevelopment] = this.isPushNotificationsDevelopment.ToString();
        dictionary[postProcessKey.isAddBackGroundModesRemoteNotifications] = this.isAddBackGroundModesRemoteNotifications.ToString();
        dictionary[postProcessKey.isAddSignInWithApple] = this.isAddSignInWithApple.ToString();
        dictionary[postProcessKey.isAddGameCenter] = this.isAddGameCenter.ToString();
        dictionary[postProcessKey.isAddInAppPurchase] = this.isAddInAppPurchase.ToString();
        dictionary[postProcessKey.isAddAssociatedDomains] = this.isAddAssociatedDomains.ToString();
        var associatedDomainsString = Json.Serialize(this.associatedDomains);
        dictionary[postProcessKey.associatedDomains] = associatedDomainsString;
        /*
        dictionary[postProcessKey.isAddGoogleServiceInfoPlist] = this.isAddGoogleServiceInfoPlist.ToString();
        dictionary[postProcessKey.googleServiceInfoPlistFilePath] = this.googleServiceInfoPlistFilePath.ToString();
        */

        return dictionary;
    }

    public void reset() {
        Debug.Log("HivePostProcessSettingIOS - reset.");

        isAddPushNotifications = defaultSetting.isAddPushNotifications;
        isPushNotificationsDevelopment = defaultSetting.isPushNotificationsDevelopment;
        isAddBackGroundModesRemoteNotifications = defaultSetting.isAddBackGroundModesRemoteNotifications;
        isAddSignInWithApple = defaultSetting.isAddSignInWithApple;
        isAddGameCenter = defaultSetting.isAddGameCenter;
        isAddInAppPurchase = defaultSetting.isAddInAppPurchase;
        isAddAssociatedDomains = defaultSetting.isAddAssociatedDomains;
        associatedDomains = defaultSetting.associatedDomains;
        /*
        isAddGoogleServiceInfoPlist = defaultSetting.isAddGoogleServiceInfoPlist;
        googleServiceInfoPlistFilePath = defaultSetting.googleServiceInfoPlistFilePath;
        */
    }

    public void apply() {
        Debug.Log("HivePostProcessSettingIOS - apply.");

        file.writePostProcessSetting(this.toDictionary());
    }

    private void load() {
        Debug.Log("HivePostProcessSettingIOS - load.");

        var dictionary = file.readPostProcessSetting();

        if (dictionary == null) {
            reset();
            return;
        }

        try {
            bool.TryParse(dictionary[postProcessKey.isAddPushNotifications], out isAddPushNotifications);
        } catch {
            Debug.Log("Set isAddPushNotifications as a default value.");
            isAddPushNotifications = defaultSetting.isAddPushNotifications;
        }

        try {
            bool.TryParse(dictionary[postProcessKey.isPushNotificationsDevelopment], out isPushNotificationsDevelopment);
        } catch {
            Debug.Log("Set isPushNotificationsDevelopment as a default value.");
            isPushNotificationsDevelopment = defaultSetting.isPushNotificationsDevelopment;
        }

        try {
            bool.TryParse(dictionary[postProcessKey.isAddBackGroundModesRemoteNotifications], out isAddBackGroundModesRemoteNotifications);
        } catch {
            Debug.Log("Set isAddBackGroundModesRemoteNotifications as a default value.");
            isAddBackGroundModesRemoteNotifications = defaultSetting.isAddBackGroundModesRemoteNotifications;
        }

        try {
            bool.TryParse(dictionary[postProcessKey.isAddBackGroundModesRemoteNotifications], out isAddBackGroundModesRemoteNotifications);
        } catch {
            Debug.Log("Set isAddBackGroundModesRemoteNotifications as a default value.");
            isAddBackGroundModesRemoteNotifications = defaultSetting.isAddBackGroundModesRemoteNotifications;
        }
        
        try {
            bool.TryParse(dictionary[postProcessKey.isAddSignInWithApple], out isAddSignInWithApple);
        } catch {
            Debug.Log("Set isAddSignInWithApple as a default value.");
            isAddSignInWithApple = defaultSetting.isAddSignInWithApple;
        }

        try {
            bool.TryParse(dictionary[postProcessKey.isAddGameCenter], out isAddGameCenter);
        } catch {
            Debug.Log("Set isAddGameCenter as a default value.");
            isAddGameCenter = defaultSetting.isAddGameCenter;
        }

        try {
            bool.TryParse(dictionary[postProcessKey.isAddInAppPurchase], out isAddInAppPurchase);
        } catch {
            Debug.Log("Set isAddInAppPurchase as a default value.");
            isAddInAppPurchase = defaultSetting.isAddInAppPurchase;
        }

        try {
            bool.TryParse(dictionary[postProcessKey.isAddAssociatedDomains], out isAddAssociatedDomains);
        } catch {
            Debug.Log("Set isAddAssociatedDomains as a default value.");
            isAddAssociatedDomains = defaultSetting.isAddAssociatedDomains;
        }
        
        try {
            string associatedDomainsString = dictionary[postProcessKey.associatedDomains];
            var associatedDomainsObjList = Json.Deserialize(associatedDomainsString) as List<object>;
            associatedDomains = associatedDomainsObjList.Select(obj => (string)obj).ToList();
        } catch {
            Debug.Log("Set associatedDomains as a default value.");
            associatedDomains = defaultSetting.associatedDomains;
        }

        /*
        googleServiceInfoPlistFilePath = dictionary[postProcessKey.googleServiceInfoPlistFilePath];
        if (string.IsNullOrEmpty(googleServiceInfoPlistFilePath)) {
            Debug.Log("Parse googleServiceInfoPlistFilePath failed.");
        }
        */
    }

}