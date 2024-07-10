using hive;
using UnityEngine;

public class HivePlatform
{
    public static bool IsSuccess(ResultAPI result)
    {
        if (false == result.isSuccess())
        {
            Debug.LogError("hive result failed");
            Debug.LogError("ErrorCode: " + result.errorCode);
            Debug.LogError("ErrorCode: " + result.errorMessage);
            return false;
        }

        if (result.needExit())
        {
            Debug.LogWarning("hive result need exit");
            return false;
        }

        return true;
    }
}