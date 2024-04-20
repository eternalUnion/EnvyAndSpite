using TMPro;
using UnityEngine;

public class Countdown : MonoBehaviour
{
	public float countdownLength;

	private float time;

	public TextMeshProUGUI countdownText;

	public float decimalFontSize;

	public bool paused;

	public UltrakillEvent onZero;

	private bool done;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void PauseState(bool pause)
	{
	}

	public void ChangeTime(float newTime)
	{
	}

	public void ResetTime()
	{
	}
}
