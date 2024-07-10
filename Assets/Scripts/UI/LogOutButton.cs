using hive;
using RM2.Login.Structures.Account;
using UnityEngine;
using UnityEngine.UI;

public class LogOutButton : MonoBehaviour
{
    public Button button;

    public void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        AuthV4.signOut(OnSignOut);
        WebServerClient.AccountTokenRevoke(OnRevokeSuccess, OnRevokeFailed);
    }

    private void OnRevokeFailed(WebServerException obj)
    {
        Debug.LogError(obj);
    }

    private void OnRevokeSuccess(TokenRevokeResponse obj)
    {
        WebServerContext.Token = "";
        InfoPanel.Inst.SetWebAccountId(0);
    }

    private void OnSignOut(ResultAPI result)
    {
        InfoPanel.Inst.SetHivePlayerId(0);
        InfoPanel.Inst.SetHivePlayerName("");
        InfoPanel.Inst.SetHivePlayerToken("");
        InfoPanel.Inst.SetHiveDid("");
    }
}