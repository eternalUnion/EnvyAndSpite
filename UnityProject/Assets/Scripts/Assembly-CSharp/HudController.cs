using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HudController : MonoBehaviour
{
	public static HudController Instance;

	public bool altHud;

	public bool colorless;

	private GameObject altHudObj;

	private HUDPos hudpos;

	public GameObject gunCanvas;

	public GameObject weaponIcon;

	public GameObject armIcon;

	public GameObject styleMeter;

	public GameObject styleInfo;

	[Space]
	public Image[] hudBackgrounds;

	public TMP_Text[] textElements;

	[Space]
	public Material normalTextMaterial;

	public Material overlayTextMaterial;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	public void CheckSituation()
	{
	}

	public void SetOpacity(float amount)
	{
	}

	public void SetAlwaysOnTop(bool onTop)
	{
	}
}
