using System.Collections.Generic;
using UnityEngine;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
public class CheatsManager : MonoSingleton<CheatsManager>
{
	[SerializeField]
	private GameObject cheatsManagerMenu;

	[Space]
	[SerializeField]
	private GameObject itemContainer;

	[SerializeField]
	private CheatMenuItem template;

	[Space]
	[SerializeField]
	private CheatMenuItem categoryTemplate;

	[Space]
	[SerializeField]
	private Color enabledColor;

	[SerializeField]
	private Color disabledColor;

	private Dictionary<ICheat, CheatMenuItem> menuItems;

	private Dictionary<string, ICheat> idToCheat;

	private Dictionary<string, List<ICheat>> allRegisteredCheats;

	private Dictionary<string, Sprite> spriteIcons;

	public static bool KeepCheatsEnabled => false;

	public void ShowMenu()
	{
	}

	public void HideMenu()
	{
	}

	public void RegisterCheat(ICheat cheat, string category = null)
	{
	}

	public void RegisterCheats(ICheat[] cheats, string category = null)
	{
	}

	public void RegisterExternalCheat(ICheat cheat)
	{
	}

	public void ToggleCheat(ICheat targetCheat)
	{
	}

	public void RefreshCheatStates()
	{
	}

	public void WrappedSetState(ICheat targetCheat, bool enable)
	{
	}

	public bool GetCheatState(string id)
	{
		return false;
	}

	public void DisableCheat(string id)
	{
	}

	public void DisableCheat(ICheat targetCheat)
	{
	}

	public void RebuildIcons()
	{
	}

	private void Start()
	{
	}

	public void CancelRebindIfNecessary()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void HandleCheatBind(string identifier)
	{
	}

	private void Update()
	{
	}

	private void OnGUI()
	{
	}

	private bool GetStartCheatState(ICheat cheat)
	{
		return false;
	}

	private void SaveCheatState(ICheat cheat)
	{
	}

	public void RenderCheatsInfo()
	{
	}

	public void UpdateCheatState(ICheat cheat)
	{
	}

	private void UpdateCheatState(CheatMenuItem item, ICheat cheat)
	{
	}

	private void ResetMenu()
	{
	}

	private void StartRebind(ICheat cheat)
	{
	}

	public void RebuildMenu()
	{
	}

	public CheatsManager()
	{

	}
}
