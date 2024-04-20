using UnityEngine;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
public class IconManager : MonoSingleton<IconManager>
{
	[SerializeField]
	private CheatAssetObject[] iconPacks;

	private int currentIconPack;

	private bool prefFetched;

	public int CurrentIconPackId => 0;

	public CheatAssetObject CurrentIcons => null;

	private int FetchSavedPref()
	{
		return 0;
	}

	public string[] AvailableIconPacks()
	{
		return null;
	}

	public void SetIconPack(int pack)
	{
	}

	public void Reload()
	{
	}

	public IconManager()
	{

	}
}
