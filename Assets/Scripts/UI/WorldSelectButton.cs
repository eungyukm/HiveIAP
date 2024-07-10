using RM2.Login.Structures.World;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class WorldSelectButton : MonoBehaviour
{
	public WorldInfo WorldInfo { get; private set; }
	public Button button;
	public Text buttonText;
	public UnityAction<WorldInfo> OnSelectedWorld;

	public void SetWorld(WorldInfo world) {
		WorldInfo = world;
		buttonText.text = $"#{world.WorldId} {world.Name} ({world.Players}/{world.MaxPlayers})";
		button.onClick.AddListener(OnButtonClick);
	}

	public void OnButtonClick()
	{
		Debug.Log("Selected World: " + WorldInfo.Name);
		
		WebServerContext.WorldId = WorldInfo.WorldId;
		WebServerContext.HashedWorldId = WorldInfo.HashedWorldId;
		
		InfoPanel.Inst.SetWorldId(WorldInfo.WorldId);
		InfoPanel.Inst.SetHashedWorldId(WorldInfo.HashedWorldId);

		ProudNetClient.Inst.SetAddress(WorldInfo.Host);
		ProudNetClient.Inst.SetPort((ushort)WorldInfo.Port);

		OnSelectedWorld?.Invoke(WorldInfo);
	}
}