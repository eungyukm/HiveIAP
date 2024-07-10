using RM2.Login.Structures.Player;
using RM2.Login.Structures.World;
using UnityEngine;
using UnityEngine.UI;

public class WorldListRequestButton : MonoBehaviour
{
    public Button button;

    public Transform worldListPanel;
    public GameObject selectWorldButtonPrefab;

    public Transform playerListPanel;
    public GameObject selectPlayerButtonPrefab;

    public void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        WebServerClient.WorldGetList(OnWorldListSuccess, OnWorldListFailed);
    }

    private void OnWorldListSuccess(WorldsResponse obj)
    {
        ClearWorldList();
        foreach (var worldInfo in obj.Worlds)
        {
            AddWorldButton(worldInfo);
        }
        GameManager.Inst.ForceUpdateCanvas();
    }

    private void ClearWorldList()
    {
        foreach (Transform child in worldListPanel)
        {
            Destroy(child.gameObject);
        }
    }

    private void AddWorldButton(WorldInfo worldInfo)
    {
        var worldSelectButton = Instantiate(selectWorldButtonPrefab, worldListPanel).GetComponent<WorldSelectButton>();
        worldSelectButton.SetWorld(worldInfo);
        worldSelectButton.OnSelectedWorld += OnWorldSelected;
    }
    
    private void OnWorldSelected(WorldInfo worldInfo)
    {
        ClearWorldList();
        PlayerGetList();
    }
    
    private void OnWorldListFailed(WebServerException obj)
    {
        Debug.LogError(obj);
    }

    public void PlayerGetList()
    {
        WebServerClient.PlayerGetList(WebServerContext.HashedWorldId, OnGetPlayerListSuccess, OnGetPlayerListFailed);
    }

    private void OnGetPlayerListSuccess(PlayerListResponse obj)
    {
        ClearPlayerList();
        foreach (var playerData in obj.Players)
        {
            AddPlayerButton(playerData);
        }
        GameManager.Inst.ForceUpdateCanvas();
    }
    
    private void ClearPlayerList()
    {
        foreach (Transform child in playerListPanel)
        {
            Destroy(child.gameObject);
        }
    }
    
    private void AddPlayerButton(LobbyPlayerData playerData)
    {
        var playerSelectButton = Instantiate(selectPlayerButtonPrefab, playerListPanel).GetComponent<PlayerSelectButton>();
        playerSelectButton.SetPlayer(playerData);
        playerSelectButton.OnSelectedPlayer += OnPlayerSelected;
    }

    private void OnPlayerSelected(LobbyPlayerData arg0)
    {
        ClearPlayerList();
    }
    
    private void OnGetPlayerListFailed(WebServerException obj)
    {
        Debug.LogError(obj);
    }
}