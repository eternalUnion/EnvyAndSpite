using UnityEngine;
using UnityEngine.UI;

public class MenuActSelect : MonoBehaviour
{
	public int requiredLevels;

	public bool forceOff;

	public bool hideWhenOff;

	public bool primeLevels;

	private Transform[] children;

	private Image img;

	private Text text;

	private string originalName;

	public string nameWhenDisabled;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
