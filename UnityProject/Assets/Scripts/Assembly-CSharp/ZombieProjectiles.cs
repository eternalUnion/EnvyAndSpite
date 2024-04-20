using UnityEngine;
using UnityEngine.AI;

public class ZombieProjectiles : MonoBehaviour
{
	public bool stationary;

	public bool smallRay;

	public bool wanderer;

	public bool afraid;

	public bool chaser;

	public bool hasMelee;

	private Zombie zmb;

	private GameObject player;

	private GameObject camObj;

	private NavMeshAgent nma;

	private NavMeshPath nmp;

	private NavMeshHit hit;

	private Animator anim;

	public Vector3 targetPosition;

	private float coolDown;

	private AudioSource aud;

	public TrailRenderer tr;

	public GameObject projectile;

	private GameObject currentProjectile;

	public Transform shootPos;

	public GameObject head;

	public bool playerSpotted;

	private RaycastHit rhit;

	private RaycastHit bhit;

	public LayerMask lookForPlayerMask;

	public bool seekingPlayer;

	private float raySize;

	private bool musicRequested;

	public GameObject decProjectileSpawner;

	public GameObject decProjectile;

	private GameObject currentDecProjectile;

	public bool swinging;

	[HideInInspector]
	public bool blocking;

	[HideInInspector]
	public int difficulty;

	private float coolDownReduce;

	private EnemyIdentifier eid;

	private GameObject origWP;

	public Transform aimer;

	private bool aiming;

	private Quaternion origRotation;

	private float aimEase;

	private SwingCheck2[] swingChecks;

	private float lengthOfStop;

	private Vector3 spawnPos;

	private bool valuesSet;

	private void Awake()
	{
	}

	private void SetValues()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void SlowUpdate()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void SetDestination(Vector3 position)
	{
	}

	public void Melee()
	{
	}

	public void MeleePrep()
	{
	}

	public void MeleeDamageStart()
	{
	}

	public void MeleeDamageEnd()
	{
	}

	public void Swing()
	{
	}

	public void SwingEnd()
	{
	}

	public void SpawnProjectile()
	{
	}

	public void DamageStart()
	{
	}

	public void ThrowProjectile()
	{
	}

	public void ShootProjectile(int skipOnEasy)
	{
	}

	public void StopTracking()
	{
	}

	public void DamageEnd()
	{
	}

	public void CancelAttack()
	{
	}

	private void Wander()
	{
	}

	public void Block(Vector3 attackPosition)
	{
	}
}
