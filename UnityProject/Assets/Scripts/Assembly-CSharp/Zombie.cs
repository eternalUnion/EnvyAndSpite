using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
	public float health;

	private int difficulty;

	private Rigidbody[] rbs;

	public bool limp;

	public NavMeshAgent nma;

	public Animator anim;

	private float currentSpeed;

	private Rigidbody rb;

	private ZombieMelee zm;

	[HideInInspector]
	public ZombieProjectiles zp;

	private AudioSource aud;

	public AudioClip[] hurtSounds;

	public float hurtSoundVol;

	public AudioClip deathSound;

	public float deathSoundVol;

	public AudioClip scream;

	private GroundCheckEnemy gc;

	public bool grounded;

	private float defaultSpeed;

	private StyleCalculator scalc;

	private EnemyIdentifier eid;

	private GoreZone gz;

	public Material deadMaterial;

	public Renderer smr;

	private Material originalMaterial;

	public GameObject chest;

	private float chestHP;

	public bool chestExploding;

	public bool attacking;

	public LayerMask lmask;

	private LayerMask lmaskWater;

	private bool noheal;

	private float speedMultiplier;

	public bool stopped;

	public bool knockedBack;

	private float knockBackCharge;

	public float brakes;

	public float juggleWeight;

	public bool falling;

	public bool noFallDamage;

	public bool musicRequested;

	private float fallSpeed;

	private float fallTime;

	private float reduceFallTime;

	private BloodsplatterManager bsm;

	public bool variableSpeed;

	private bool chestExploded;

	private int parryFramesLeft;

	private void Awake()
	{
	}

	private GoreZone GetGoreZone()
	{
		return null;
	}

	private void UpdateBuff()
	{
	}

	private void SetSpeed()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void KnockBack(Vector3 force)
	{
	}

	public void StopKnockBack()
	{
	}

	public void GetHurt(GameObject target, Vector3 force, float multiplier, float critMultiplier, GameObject sourceWeapon = null)
	{
	}

	public void GoLimp()
	{
	}

	public void ChestExplodeEnd()
	{
	}

	public void StopHealing()
	{
	}

	private void ReadyGib((GameObject, BSType) tempGib, GameObject target)
	{
	}

	public void ChestExplosion(bool cut = false)
	{
	}

	public void Cut(GameObject target)
	{
	}

	public void ParryableCheck()
	{
	}
}
