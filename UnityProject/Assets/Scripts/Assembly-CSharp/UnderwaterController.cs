using UnityEngine;
using UnityEngine.UI;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
public class UnderwaterController : MonoSingleton<UnderwaterController>
{
	public Image overlay;

	private Color defaultColor;

	private Color offColor;

	private int underWaterCalls;

	private AudioLowPassFilter lowPass;

	public bool inWater;

	private AudioSource aud;

	public AudioClip underWater;

	public AudioClip surfacing;

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	public void InWater(Color clr)
	{
	}

	public void OutWater()
	{
	}

	public UnderwaterController()
	{

	}
}
