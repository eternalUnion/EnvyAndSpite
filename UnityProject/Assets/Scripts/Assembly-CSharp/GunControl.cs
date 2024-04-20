using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
public class GunControl : MonoSingleton<GunControl>
{
	private InputManager inman;

	public bool activated;

	private int rememberedSlot;

	public int currentVariation;

	public int currentSlot;

	public GameObject currentWeapon;

	public List<List<GameObject>> slots;

	public List<GameObject> slot1;

	public List<GameObject> slot2;

	public List<GameObject> slot3;

	public List<GameObject> slot4;

	public List<GameObject> slot5;

	public List<GameObject> slot6;

	public List<GameObject> allWeapons;

	public Dictionary<GameObject, int> slotDict;

	public List<WeaponIcon> currentWeaponIcons;

	private AudioSource aud;

	public float killCharge;

	public Slider killMeter;

	public bool noWeapons;

	public int lastUsedSlot;

	public int lastUsedVariation;

	private Dictionary<int, int> retainedVariations;

	public float headShotComboTime;

	public int headshots;

	private bool hookCombo;

	private StyleHUD shud;

	public GameObject[] gunPanel;

	private float scrollCooldown;

	private const float WeaponWheelTime = 0.25f;

	[HideInInspector]
	public int dualWieldCount;

	[HideInInspector]
	public bool stayUnarmed;

	[HideInInspector]
	public bool variationMemory;

	private void Start()
	{
	}

	private void CalculateSlotCount()
	{
	}

	private void Update()
	{
	}

	private void OnGUI()
	{
	}

	public void SwitchWeapon(int target)
	{
	}

	private void RetainVariation(int slot, int variationIndex)
	{
	}

	public void SwitchWeapon(int target, List<GameObject> slot, bool lastUsedSlot = false, bool useRetainedVariation = false, bool scrolled = false)
	{
	}

	public void ForceWeapon(GameObject weapon)
	{
	}

	public void NoWeapon()
	{
	}

	public void YesWeapon()
	{
	}

	public void AddKill()
	{
	}

	public void ClearKills()
	{
	}

	public void UpdateWeaponList(bool firstTime = false)
	{
	}

	public void UpdateWeaponIcon(bool firstTime = false)
	{
	}

	public GunControl()
	{

	}
}
