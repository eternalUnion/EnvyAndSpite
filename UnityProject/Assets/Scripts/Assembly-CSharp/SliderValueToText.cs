using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderValueToText : MonoBehaviour
{
	public DecimalType decimalType;

	private string decString;

	private Slider targetSlider;

	private Text targetText;

	private TMP_Text targetTextTMP;

	public string suffix;

	public string ifMax;

	public string ifMin;

	public Color minColor;

	public Color maxColor;

	private Color origColor;

	private Color nullColor;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
