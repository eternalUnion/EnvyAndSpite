using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
public class FistControl : MonoSingleton<FistControl>
{
	private InputManager inman;

	public ForcedLoadout forcedLoadout;

	public AssetReference blueArm;

	public AssetReference redArm;

	public AssetReference goldArm;

	private int currentOrderNum;

	private int currentVarNum;

	private List<GameObject> spawnedArms;

	private List<int> spawnedArmNums;

	private AudioSource aud;

	public bool shopping;

	private int shopRequests;

	public GameObject[] fistPanels;

	public Image fistIcon;

	public ItemIdentifier heldObject;

	public float fistCooldown;

	public float weightCooldown;

	private bool _activated;

	public Punch currentPunch;

	[HideInInspector]
	public int forceNoHold;

	private bool zooming;

	public bool activated
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public GameObject currentArmObject => null;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ScrollArm()
	{
	}

	public void RefreshArm()
	{
	}

	public void ForceArm(int varNum, bool animation = false)
	{
	}

	public void ArmChange(int orderNum)
	{
	}

	public void UpdateFistIcon()
	{
	}

	public void NoFist()
	{
	}

	public void YesFist()
	{
	}

	public void ResetFists()
	{
	}

	private void CheckFist(string name)
	{
	}

	public void ShopMode()
	{
	}

	public void StopShop()
	{
	}

	public void ResetHeldItemPosition()
	{
	}

	public void TutorialCheckForArmThatCanPunch()
	{
	}

	public FistControl()
	{

	}
}
