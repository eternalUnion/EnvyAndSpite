using System.Collections.Generic;
using UnityEngine;

public class WaveMenu : MonoBehaviour
{
	[HideInInspector]
	public List<WaveSetter> setters;

	private int highestWave;

	private int currentWave;

	private void Start()
	{
	}

	public ButtonState CheckWaveAvailability(WaveSetter ws)
	{
		return default(ButtonState);
	}

	private void GetHighestWave()
	{
	}

	public void SetCurrentWave(int wave)
	{
	}
}
