using RM2.Login.Structures.Player;
using UnityEngine;
using UnityEngine.UI;

public class CreatePlayerButton : MonoBehaviour
{
    public Button button;
    public WorldListRequestButton worldListRequestButton;

    public void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        var body = new PlayerCreateBody
        {
            Slot = 0,
            Name = "",
            ClassId = 111,
            Face = "",
            Customize = "{\"HairIndex\":6,\"HairColorIndex\":1,\"HeadIndex\":1,\"SkinColorIndex\":2}"
        };
        
        WebServerClient.PlayerCreate(WebServerContext.HashedWorldId, body, OnCharacterCreateSuccess, OnCharacterCreateFailed);
    }

    private void OnCharacterCreateSuccess(PlayerResponse obj)
    {
        worldListRequestButton.PlayerGetList();
    }

    private void OnCharacterCreateFailed(WebServerException obj)
    {
        Debug.LogError(obj);
    }
}