using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class IntroTextController : MonoBehaviour
{
	public bool firstTime;

	public GameObject page1Screen;

	public GameObject page1SecondTimeScreen;

	public GameObject page2Screen;

	public GameObject page2NoFade;

	public GameObject[] deactivateOnIntroEnd;

	public Slider soundSlider;

	public Slider musicSlider;

	private AudioMixer[] audmix;

	private Image img;

	private TMP_Text page2Text;

	private float fadeValue;

	private bool inMenu;

	public bool introOver;

	private float introOverWait;

	private Rigidbody rb;

	private void Awake()
	{
	}

	public void DoneWithSetting()
	{
	}

	private void Start()
	{
	}

	private void SlowDown()
	{
	}

	private void Update()
	{
	}
}
