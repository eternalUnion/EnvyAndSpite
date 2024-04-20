using Sandbox;
using UnityEngine;

public class HookPoint : MonoBehaviour, IAlter, IAlterOptions<float>
{
	public bool active;

	public hookPointType type;

	public float slingShotForce;

	[HideInInspector]
	public bool valuesSet;

	public MeshRenderer[] renderers;

	[HideInInspector]
	public Material[] origMats;

	[HideInInspector]
	public Spin[] spins;

	[HideInInspector]
	public Light lit;

	public Transform outerOrb;

	public Transform innerOrb;

	public Material disabledMaterial;

	public ParticleSystem activeParticle;

	private bool hooked;

	private AudioSource aud;

	public GameObject grabParticle;

	public GameObject reachParticle;

	public float reactivationTime;

	[HideInInspector]
	public float timer;

	private float currentReactivationTimer;

	private float tickTimer;

	public AudioSource reactivationTick;

	[Header("Events")]
	public UltrakillEvent onHook;

	public UltrakillEvent onUnhook;

	public UltrakillEvent onReach;

	public string alterKey => null;

	public string alterCategoryName => null;

	public AlterOption<float>[] options => null;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Hooked()
	{
	}

	public void Unhooked()
	{
	}

	public void Reached()
	{
	}

	public void Reached(Vector3 direction)
	{
	}

	public void SwitchPulled()
	{
	}

	public void Activate()
	{
	}

	public void Deactivate()
	{
	}

	private void TurnOn()
	{
	}

	private void TurnOff()
	{
	}

	private void SetValues()
	{
	}

	public void TimerStop()
	{
	}
}
