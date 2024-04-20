using UnityEngine;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
public class PostProcessV2_Handler : MonoSingleton<PostProcessV2_Handler>
{
	public Shader outlineCreate;

	private Material outlineProcessor;

	public Material postProcessV2_VSRM;

	[Space(10f)]
	public Texture sandTex;

	public Texture buffTex;

	public Texture ditherTexture;

	public int distance;

	private Camera mainCam;

	public Camera hudCam;

	public Camera virtualCam;

	private RenderBuffer[] buffers;

	private RenderTexture mainTex;

	private RenderTexture hudTex;

	private RenderTexture outlineTex_BufferA;

	private RenderTexture outlineTex_BufferB;

	private int width;

	private int height;

	private int lastWidth;

	private int lastHeight;

	private bool reinitializeTextures;

	private bool mainCameraOnly;

	[HideInInspector]
	public bool enableJFA;

	[HideInInspector]
	public float downscaleResolution;

	public Texture CurrentTexture;

	public Texture CurrentMapPaletteOverride;

	public Material radiantBuff;

	private OptionsManager oman;

	public bool debugFooled;

	[SerializeField]
	private Material conversionMaterial;

	private bool isGLCore;

	private void OnValidate()
	{
	}

	private void Start()
	{
	}

	public void Fooled(bool doEnable)
	{
	}

	public void ColorPalette(bool stuff)
	{
	}

	public void ApplyUserColorPalette(Texture tex)
	{
	}

	public void ApplyMapColorPalette(Texture tex)
	{
	}

	private void ReinitializeCameras()
	{
	}

	private void SetupRTs()
	{
	}

	private void ComputeOutlines()
	{
	}

	public void ChangeCamera(bool hudless)
	{
	}

	public void OnPreRenderCallback(Camera cam)
	{
	}

	private void OnPostRenderCallback(Camera cam)
	{
	}

	protected override void OnDestroy()
	{
	}

	public PostProcessV2_Handler()
	{

	}
}
