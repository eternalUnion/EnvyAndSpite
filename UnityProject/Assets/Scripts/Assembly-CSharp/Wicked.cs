using UnityEngine;
using UnityEngine.AI;

public class Wicked : MonoBehaviour
{
	public Transform[] patrolPoints;

	public Transform targetPoint;

	private GameObject player;

	public LayerMask lmask;

	public float playerSpotTime;

	private AudioSource aud;

	private NavMeshAgent nma;

	public GameObject hitSound;

	private bool lineOfSight;

	private EnemyIdentifier eid;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void GetHit()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
