using RM2.Login.Structures.Account;
using UnityEngine;
using UnityEngine.UI;

public class CreateAccountNameButton : MonoBehaviour
{
    public InputField inputField;
    public Button button;

    public void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        var body = new AccountNameCreateBody
        {
            AccountName = inputField.text,
        };
        
        WebServerClient.AccountSetName(body, OnNameCreateSuccess, OnNameCreateFailed);
    }

    private void OnNameCreateSuccess(AccountNameCreateResponse obj)
    {
        Debug.Log("account name create success");
    }

    private void OnNameCreateFailed(WebServerException obj)
    {
        Debug.LogError(obj);
    }
}