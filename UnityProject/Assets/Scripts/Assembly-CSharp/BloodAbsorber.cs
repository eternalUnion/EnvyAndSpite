using UnityEngine;
using UnityEngine.Rendering;

public class BloodAbsorber : MonoBehaviour
{
	public int resolution;

	public Shader absorptionShader;

	public Texture noiseTex;

	public float bloodUpdateRate;

	public float timeUntilSleep;

	public bool clearBlood;

	private float bloodTimer;

	private bool isSleeping;

	private float sleepTimer;

	private CommandBuffer cb;

	private Material absMat;

	public RenderTexture paintBuffer;

	public RenderTexture bloodMap;

	private Renderer rend;

	private MaterialPropertyBlock propBlock;

	private MeshFilter mf;

	private void Start()
	{
	}

	private void OnValidate()
	{
	}

	private void Update()
	{
	}

	public void RenderBlood(Vector3 hitPos)
	{
	}
}
