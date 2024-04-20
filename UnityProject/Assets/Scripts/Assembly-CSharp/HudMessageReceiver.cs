using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
public class HudMessageReceiver : MonoSingleton<HudMessageReceiver>
{
	private Image img;

	[HideInInspector]
	public TMP_Text text;

	private AudioSource aud;

	private HudOpenEffect hoe;

	private string message;

	private string input;

	private string message2;

	private bool noSound;

	private void Start()
	{
	}

	private void Done()
	{
	}

	public void SendHudMessage(string newmessage, string newinput = "", string newmessage2 = "", int delay = 0, bool silent = false)
	{
	}

	private void ShowHudMessage()
	{
	}

	public void ClearMessage()
	{
	}

	public HudMessageReceiver()
	{

	}
}
