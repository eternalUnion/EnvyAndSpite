using Sandbox;
using ScriptableObjects;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class SandboxAltar : MonoBehaviour, IAlter, IAlterOptions<bool>, IAlterOptions<int>
{
	public AltarType altarType;

	private AssetReference[] altarPrefabs;

	[SerializeField]
	private GameObject skullPrefab;

	[SerializeField]
	private Transform defaultLocation;

	[SerializeField]
	private Collider altarTrigger;

	[SerializeField]
	private Altars altars;

	private bool hasSkull;

	private GameObject skull;

	public string alterKey => null;

	public string alterCategoryName => null;

	AlterOption<bool>[] IAlterOptions<bool>.options => null;

	AlterOption<int>[] IAlterOptions<int>.options => null;

	private void Awake()
	{
	}

	public void CreateSkull()
	{
	}

	public void SetSkullActive(bool active)
	{
	}

	public void RemoveSkull()
	{
	}
}
