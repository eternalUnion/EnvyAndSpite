using UnityEngine;

public class AnimatedTexture : MonoBehaviour
{
	[SerializeField]
	private int materialIndex;

	[SerializeField]
	private float delay;

	[SerializeField]
	private Texture2D[] framePool;

	[SerializeField]
	private TextureType textureType;

	private TimeSince counter;

	private int selector;

	private MaterialPropertyBlock block;

	private Renderer renderer;

	private static readonly int MainTexID;

	private static readonly int EmissiveTexID;

	private int texID;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
