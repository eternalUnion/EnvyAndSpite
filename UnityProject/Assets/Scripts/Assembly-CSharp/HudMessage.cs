using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class HudMessage : MonoBehaviour
{
	private HudMessageReceiver messageHud;

	public InputActionReference actionReference;

	public bool timed;

	public bool deactivating;

	public bool notOneTime;

	public bool dontActivateOnTriggerEnter;

	public bool silent;

	public bool deactiveOnTriggerExit;

	public bool deactiveOnDisable;

	private bool activated;

	public string message;

	public string message2;

	private Image img;

	private TMP_Text text;

	public string playerPref;

	private bool colliderless;

	public float timerTime;

	private string PlayerPref => null;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void Done()
	{
	}

	private void Begone()
	{
	}

	public void PlayMessage(bool hasToBeEnabled = false)
	{
	}

	public void ChangeMessage(string newMessage)
	{
	}
}
