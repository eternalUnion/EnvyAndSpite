using UnityEngine;

public class ScaleNFade : MonoBehaviour
{
	public bool scale;

	public bool fade;

	public FadeType ft;

	public float scaleSpeed;

	public float fadeSpeed;

	private SpriteRenderer sr;

	private LineRenderer lr;

	private Light lght;

	private Renderer rend;

	public bool dontDestroyOnZero;

	public bool lightUseIntensityInsteadOfRange;

	public bool fadeToBlack;

	private Vector3 scaleAmt = Vector3.one;

	private bool hasOpacScale;

	private bool hasTint;

	private bool hasColor;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateSpriteFade()
	{
	}

	private void UpdateLightFade()
	{
	}

	private void UpdateRendererFade()
	{
	}

	private void UpdateOpacityScale()
	{
	}

	private void FixedUpdate()
	{
	}
}
