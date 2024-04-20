using UnityEngine;
using UnityEngine.AI;

public class ZombieMelee : MonoBehaviour
{
	public bool harmless;

	public bool damaging;

	public TrailRenderer tr;

	public bool track;

	private AudioSource aud;

	public float coolDown;

	public Zombie zmb;

	private NavMeshAgent nma;

	private Animator anim;

	private EnemyIdentifier eid;

	private bool customStart;

	private bool musicRequested;

	private int difficulty;

	private float defaultCoolDown;

	public GameObject swingSound;

	public LayerMask lmask;

	private Rigidbody rb;

	private SwingCheck2 swingCheck;

	private EnemySimplifier ensim;

	public Material originalMaterial;

	public Material biteMaterial;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void FixedUpdate()
	{
	}

	public void Swing()
	{
	}

	public void SwingEnd()
	{
	}

	public void DamageStart()
	{
	}

	public void DamageEnd()
	{
	}

	public void StopTracking()
	{
	}

	public void CancelAttack()
	{
	}

	public void TrackTick()
	{
	}

	public void MouthClose()
	{
	}

	private void MouthOpen()
	{
	}
}
