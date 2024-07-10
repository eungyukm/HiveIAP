using UnityEngine;
using UnityEngine.UI;

public class InfoPanel : MonoBehaviour
{
    public static InfoPanel Inst { get; private set; }

    [SerializeField]
    private Text hivePlayerId;

    [SerializeField]
    private Text hivePlayerName;

    [SerializeField]
    private Text hiveToken;

    [SerializeField]
    private Text hiveDid;

    [SerializeField]
    private Text webAccountId;

    [SerializeField]
    private Text gameServerConnectionState;

    [SerializeField]
    private Text worldId;

    [SerializeField]
    private Text hashedWorldId;

    [SerializeField]
    private Text playerId;

    [SerializeField]
    private Text hashedPlayerId;

    public void Awake()
    {
        if (Inst != null)
        {
            return;
        }

        Inst = this;
    }

    public void Start()
    {
        Clear();
    }

    public void Clear()
    {
        SetHivePlayerId(0);
        SetHivePlayerName("");
        SetHivePlayerToken("");
        SetHiveDid("");
        SetWebAccountId(0);
        SetGameServerConnectionState(false);
        SetWorldId(0);
        SetHashedWorldId("");
        SetPlayerId(0);
        SetHashedPlayerId("");
    }

    public void SetHivePlayerId(long value) => hivePlayerId.text = (value) + "\n";
    public void SetHivePlayerName(string value) => hivePlayerName.text = (value) + "\n";
    public void SetHivePlayerToken(string value) => hiveToken.text = (value) + "\n";
    public void SetHiveDid(string value) => hiveDid.text = (value) + "\n";
    public void SetWebAccountId(long value) => webAccountId.text = (value) + "\n";
    public void SetGameServerConnectionState(bool value) => gameServerConnectionState.text = (value ? "Connected" : "Disconnected") + "\n";
    public void SetWorldId(long value) => worldId.text = (value) + "\n";
    public void SetHashedWorldId(string value) => hashedWorldId.text = (value) + "\n";
    public void SetPlayerId(long value) => playerId.text = (value) + "\n";
    public void SetHashedPlayerId(string value) => hashedPlayerId.text = (value) + "\n";

    public string GetHivePlayerId() => hivePlayerId.text;
    public string GetHivePlayerName() => hivePlayerName.text;
    public string GetHivePlayerToken() => hiveToken.text;
    public string GetHiveDid() => hiveDid.text;
    public string GetWebAccountId() => webAccountId.text;
    public string GetGameServerConnectionState() => gameServerConnectionState.text;
    public string GetWorldId() => worldId.text;
    public string GetHashedWorldId() => hashedWorldId.text;
    public string GetPlayerId() => playerId.text;
    public string GetHashedPlayerId() => hashedPlayerId.text;
}