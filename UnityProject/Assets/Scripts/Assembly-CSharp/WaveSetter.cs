using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WaveSetter : MonoBehaviour
{
	public int wave;

	private WaveMenu wm;

	private ButtonState state;

	private ControllerPointer pointer;

	private bool prepared;

	[SerializeField]
	private GameObject buttonFail;

	[SerializeField]
	private GameObject buttonSuccess;

	[SerializeField]
	private Image buttonGraphic;

	[SerializeField]
	private TMP_Text buttonText;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnPointerClick()
	{
	}

	public void Selected()
	{
	}

	public void Unselected()
	{
	}

	public void Locked()
	{
	}

	private void Prepare()
	{
	}
}
