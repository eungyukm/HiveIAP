using System.Collections.Generic;
using System.Linq;
using System.Text;
using hive;
using UnityEngine;
using UnityEngine.UI;

public class HiveLoginButton : MonoBehaviour
{
    public Button button;
    public HiveMarket market;

    public void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        AuthV4.setup(OnAuthV4Setup);
    }

    private void OnAuthV4Setup(ResultAPI result, bool isAutoSignIn, string did, List<AuthV4.ProviderType> providerTypeList)
    {
        if (false == HivePlatform.IsSuccess(result))
        {
            return;
        }

        var builder = new StringBuilder();
        builder.AppendLine("AuthV4.setup success");
        builder.AppendLine("isautosignin: " + isAutoSignIn);
        builder.AppendLine("did: " + did);
        builder.AppendLine("providerTypeList: " + string.Join(", ", providerTypeList.Select(x => x.ToString())));

        Debug.Log(builder.ToString());
        if (isAutoSignIn) AuthV4.signIn(AuthV4.ProviderType.AUTO, OnSignIn);
        else AuthV4.showSignIn(OnSignIn);
    }

    private void OnSignIn(ResultAPI result, AuthV4.PlayerInfo playerInfo)
    {
        if (false == HivePlatform.IsSuccess(result)) return;

        var builder = new StringBuilder();
        builder.AppendLine("AuthV4.signIn success");
        builder.AppendLine("playerId: " + playerInfo.playerId);
        builder.AppendLine("playerName: " + playerInfo.playerName);
        builder.AppendLine("playerToken: " + playerInfo.playerToken);
        builder.AppendLine("did: " + playerInfo.did);

        Debug.Log(builder.ToString());

        InfoPanel.Inst.SetHivePlayerId(playerInfo.playerId);
        InfoPanel.Inst.SetHivePlayerName(playerInfo.playerName);
        InfoPanel.Inst.SetHivePlayerToken(playerInfo.playerToken);
        InfoPanel.Inst.SetHiveDid(playerInfo.did);
        
        market.MarketConnect();
    }
}