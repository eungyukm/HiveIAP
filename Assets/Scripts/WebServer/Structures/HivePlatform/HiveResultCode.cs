namespace RM2.Login.Structures.HivePlatform
{
    public enum HiveResultCode
    {
        Success = 0,
        RefundToBeRepaidUser = 2300,
        InvalidParameter = 4000,
        RequestJsonError = 4001,
        HiveAuthKeyError = 4002,
        DatabaseError = 5000,
        DistributedEnvironmentInvalidToken = 5001,
        InvalidAppId = 6000,
        IDPTokenError = 6001,
        InvalidToken = 7000,
        NoTokenInHeader = 7001,
        Unknown = 9999
    }
}