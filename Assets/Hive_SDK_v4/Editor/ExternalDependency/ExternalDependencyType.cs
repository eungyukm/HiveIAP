/**
 * @file    ExternalDependencyType.cs
 * 
 * @date    2020-2024
 * @copyright Copyright © Com2uS Platform Corporation. All Right Reserved.
 */

namespace Hive.Unity.Editor
{
    using System.ComponentModel;

    public enum ExternalDependencyType
    {
        // IDP
        [Description("ProviderGoogle")]
        Google,
        [Description("ProviderGooglePlayGames")]
        GooglePlayGames,
        [Description("ProviderFacebook")]
        Facebook,
        [Description("ProviderFacebookCloud")]
        FacebookCloud,
        [Description("ProviderApple")]
        Apple,              // Apple GameCenter (iOS Only)
        [Description("ProviderAppleSignIn")]
        AppleSignIn,        // Sign In With Apple (Android Only)
        [Description("ProviderLine")]
        Line,
        [Description("ProviderVK")]
        VK,
        [Description("ProviderQQ")]
        QQ,
        [Description("ProviderWechat")]
        Wechat,
        [Description("ProviderWeverse")]
        Weverse,
        [Description("ProviderHiveMembership")]
        HiveMembership,
        [Description("ProviderHuawei")]
        Huawei,             // Huawei (Global)

        // Analytics
        [Description("ProviderAdjust")]
        Adjust,
        [Description("ProviderSingular")]
        Singular,
        [Description("ProviderAppsFlyer")]
        AppsFlyer,
        [Description("ProviderFirebase")]
        Firebase,

        // Hive Module
        [Description("HivePromotion")]
        HivePromotion,
        [Description("HiveGoogleInAppReview")]
        GoogleInAppReview,
        [Description("HiveDeviceManagement")]
        HiveDeviceManagement,
        [Description("HiveRealNameVerification")]
        HiveRealNameVerification,
        [Description("ProviderRecaptcha")]
        Recaptcha,
        [Description("Hercules")]
        Hercules,
        [Description("HiveGoogleInAppUpdate")]
        GoogleInAppUpdate,
        [Description("HiveDataStore")]
        DataStore,
        [Description("HiveAnalyticsConsentMode")]
        AnalyticsConsentMode,
        
        //Push
        [Description("PushGoogleFcm")]
        PushGoogleFcm,
        [Description("PushFacebookCloudA2u")]
        PushFacebookCloudA2u,
        [Description("PushAmazonAdm")]
        PushAmazonAdm,

        // Market
        [Description("MarketAmazon")]
        MarketAmazon,
        [Description("MarketApple")]
        MarketApple,
        [Description("MarketFacebookCloud")]
        MarketFacebookCloud,
        [Description("MarketGoogle")]
        MarketGoogle,
        [Description("MarketOneStore")]
        MarketOneStore,
        [Description("MarketSamsung")]
        MarketSamsung,
        [Description("MarketHuawei")]
        MarketHuawei,
        [Description("MarketLebi")]
        MarketLebi,
        [Description("MarketHiveStore")]
        MarketHiveStore,

        /** 
         * 'MigVer4230000' 더이상 사용하지 않음
         *  - Hive 23.0.0 개발 시 savedata 업데이트 여부 저장하는 키로 사용
         */
        // Last Migrated Version
        // [Description("MigVer4230000")]
        // MigVer4230000
    }
}