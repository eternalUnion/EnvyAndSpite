using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
public class GraphicsOptions : MonoSingleton<GraphicsOptions>
{
	public TMP_Dropdown pixelization;

	public Slider textureWarping;

	public TMP_Dropdown vertexWarping;

	public TMP_Dropdown colorCompression;

	public Toggle vSync;

	public Slider dithering;

	public Toggle colorPalette;

	public Slider gamma;

	private new void Awake()
	{
	}

	private void Start()
	{
	}

	public void ApplyPalette(Texture2D palette)
	{
	}

	public void PCPreset()
	{
	}

	public void PSXPreset()
	{
	}

	public void Initialize()
	{
	}

	public void Gamma(float stuff)
	{
	}

	public void Pixelization(int stuff)
	{
	}

	public void TextureWarping(float stuff)
	{
	}

	public void VertexWarping(int stuff)
	{
	}

	public void ColorCompression(int stuff)
	{
	}

	public static void ColorCompressionApply(int stuff)
	{
	}

	public void Dithering(float stuff)
	{
	}

	public void VSync(bool stuff)
	{
	}

	public void ColorPalette(bool stuff)
	{
	}

	public GraphicsOptions()
	{

	}
}
