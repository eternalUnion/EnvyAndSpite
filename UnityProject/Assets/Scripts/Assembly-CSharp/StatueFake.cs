using UnityEngine;

public class StatueFake : MonoBehaviour
{
	private Animator anim;

	private AudioSource aud;

	private ParticleSystem part;

	public GameObject[] toDeactivate;

	public GameObject enemyObject;

	public bool spawn;

	public GameObject[] toActivate;

	public bool quickSpawn;

	[HideInInspector]
	public bool beingActivated;

	private void Start()
	{
	}

	public void Activate()
	{
	}

	public void Crack()
	{
	}

	public void Done()
	{
	}

	private void SlowStart()
	{
	}
}
