using UnityEngine;

public class RandomPitch : MonoBehaviour
{
	public float defaultPitch;

	public float pitchVariation;

	public bool oneTime;

	public bool playOnEnable;

	public bool nailgunOverheatFix;

	private bool beenPlayed;

	public AudioSource aud;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void Activate()
	{
	}
}
