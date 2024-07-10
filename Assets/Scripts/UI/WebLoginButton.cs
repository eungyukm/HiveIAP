using hive;
using RM2.Login.Structures.Account;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class WebLoginButton : MonoBehaviour
{
    public Button button;

    public void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        var appId = Configuration.getAppId();
        var playerInfo = AuthV4.getPlayerInfo();

        var body = new HiveLoginBody
        {
            DeviceId = SystemInfo.deviceUniqueIdentifier,
            PlatformInfo = Application.platform.ToString(),
            DeviceInfo = "IAP_SAMPLE_APP",
            AppId = appId,
            PlayerId = playerInfo.playerId.ToString(),
            Did = playerInfo.did,
            AuthenticationKey = playerInfo.playerToken,
        };

        WebServerClient.AccountIssueTokenByHive(body, OnLoginSuccess, OnLoginFailed);
    }

    private static void OnLoginSuccess(LoginResponse resp)
    {
        WebServerContext.Token = resp.Token;
        InfoPanel.Inst.SetWebAccountId(resp.AccountId);
    }

    private static void OnLoginFailed(WebServerException ex)
    {
        Debug.LogError(ex);
    }
}