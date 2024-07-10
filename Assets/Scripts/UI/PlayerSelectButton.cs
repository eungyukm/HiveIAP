using RM2.Login.Structures.Player;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PlayerSelectButton : MonoBehaviour
{
    public LobbyPlayerData Player { get; set; }
    
    public Button button;
    public Text buttonText;

    public UnityAction<LobbyPlayerData> OnSelectedPlayer;
    
    public void SetPlayer(LobbyPlayerData data)
    {
        Player = data;
        buttonText.text = $"#{Player.PlayerId} {Player.Name} ({Player.Level})";
        button.onClick.AddListener(OnButtonClick);
    }

    public void OnButtonClick()
    {
        WebServerContext.PlayerId = Player.PlayerId;
        WebServerContext.HashedPlayerId = Player.HashedPlayerId;

        InfoPanel.Inst.SetPlayerId(Player.PlayerId);
        InfoPanel.Inst.SetHashedPlayerId(Player.HashedPlayerId);

        OnSelectedPlayer.Invoke(Player);
    }
}