using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
public class HUDOptions : MonoSingleton<HUDOptions>
{
	public Action<bool> alwaysOnTopChanged;

	public TMP_Dropdown hudType;

	private HudController[] hudCons;

	public Slider bgOpacity;

	public Toggle alwaysOnTop;

	public Material hudMaterial;

	public Material hudTextMaterial;

	private Mask[] masks;

	public Toggle weaponIcon;

	public Toggle armIcon;

	public Toggle railcannonMeter;

	public Toggle styleMeter;

	public Toggle styleInfo;

	[SerializeField]
	private TMP_Dropdown iconPackDropdown;

	private Crosshair crosshair;

	public TMP_Dropdown crossHairType;

	public TMP_Dropdown crossHairColor;

	public TMP_Dropdown crossHairHud;

	public Toggle crossHairHudFade;

	[SerializeField]
	private Toggle powerUpMeter;

	[HideInInspector]
	public static bool powerUpMeterEnabled;

	private void Start()
	{
	}

	public void SetIconPack(int packId)
	{
	}

	public void CrossHairType(int stuff)
	{
	}

	public void CrossHairColor(int stuff)
	{
	}

	public void CrossHairHud(int stuff)
	{
	}

	public void HudType(int stuff)
	{
	}

	public void HudFade(bool stuff)
	{
	}

	public void PowerUpMeterEnable(bool stuff)
	{
	}

	public void BgOpacity(float stuff)
	{
	}

	public void AlwaysOnTop(bool stuff)
	{
	}

	public void WeaponIcon(bool stuff)
	{
	}

	public void ArmIcon(bool stuff)
	{
	}

	public void RailcannonMeterOption(bool stuff)
	{
	}

	public void StyleMeter(bool stuff)
	{
	}

	public void StyleInfo(bool stuff)
	{
	}

	public HUDOptions()
	{

	}
}
