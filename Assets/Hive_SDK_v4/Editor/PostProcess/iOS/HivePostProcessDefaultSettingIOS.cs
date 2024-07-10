using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class HivePostProcessDefaultSettingIOS {
    public readonly bool isAddPushNotifications = true;
    public readonly bool isPushNotificationsDevelopment = true;
    public readonly bool isAddBackGroundModesRemoteNotifications = true;
    public readonly bool isAddSignInWithApple = false;
    public readonly bool isAddGameCenter = false;
    public readonly bool isAddInAppPurchase = true;
    public readonly bool isAddAssociatedDomains = false;
    public readonly List<string> associatedDomains = new List<string> {"applinks:hiveota.withhive.com", 
                                                    "applinks:promotion.qpyou.cn", 
                                                    "applinks:test-promotion.qpyou.cn", 
                                                    "applinks:sandbox-promotion.qpyou.cn",
                                                    "applinks:mv64.adj.st",};
    /*// GoogleService-Info.plist
    public readonly bool isAddGoogleServiceInfoPlist = true;
    public readonly string googleServiceInfoPlistFilePath = "Assets/ExternalResources/iOS";
    */
}