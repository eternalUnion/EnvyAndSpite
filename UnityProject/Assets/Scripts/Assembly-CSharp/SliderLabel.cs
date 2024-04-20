using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderLabel : MonoBehaviour
{
	public bool floor;

	public float multiplier;

	[SerializeField]
	private Slider slider;

	[SerializeField]
	private string postfix;

	private TMP_Text text;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
