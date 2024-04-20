using UnityEngine;

public class LightPillar : MonoBehaviour
{
	public bool gotValues;

	public bool activated;

	public bool completed;

	private Light[] lights;

	private AudioSource aud;

	[HideInInspector]
	public Vector3 origScale;

	[HideInInspector]
	public float lightRange;

	[HideInInspector]
	public float origPitch;

	public float speed;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ActivatePillar()
	{
	}
}
