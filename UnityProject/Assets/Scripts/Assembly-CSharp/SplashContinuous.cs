using UnityEngine;
using UnityEngine.AI;

public class SplashContinuous : MonoBehaviour
{
	private bool active;

	private float cooldown;

	[SerializeField]
	private ParticleSystem particles;

	[SerializeField]
	private GameObject wadingSound;

	[SerializeField]
	private AudioClip[] wadingSounds;

	[SerializeField]
	private float wadingSoundPitch;

	private Vector3 previousPosition;

	[SerializeField]
	private float movingEmissionRate;

	[SerializeField]
	private float stillEmissionRate;

	[HideInInspector]
	public NavMeshAgent nma;

	private void FixedUpdate()
	{
	}

	public void DestroySoon()
	{
	}

	private void DestroyNow()
	{
	}
}
