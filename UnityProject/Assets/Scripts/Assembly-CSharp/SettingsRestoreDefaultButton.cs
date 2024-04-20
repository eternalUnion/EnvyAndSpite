using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SettingsRestoreDefaultButton : MonoBehaviour
{
	[SerializeField]
	private GameObject buttonContainer;

	public string settingKey;

	[Header("Float")]
	[SerializeField]
	private Slider slider;

	[SerializeField]
	private float valueToPrefMultiplier;

	[SerializeField]
	private float sliderTolerance;

	[SerializeField]
	private bool integerSlider;

	[Header("Integer")]
	[SerializeField]
	private TMP_Dropdown dropdown;

	[Header("Boolean")]
	[SerializeField]
	private Toggle toggle;

	[SerializeField]
	private UnityEvent customToggleEvent;

	private float? defaultFloat;

	private int? defaultInt;

	private bool? defaultBool;

	public void RestoreDefault()
	{
	}

	private void Start()
	{
	}

	private void UpdateSelf()
	{
	}

	private int? ReadCurrentInt()
	{
		return null;
	}
}
