using UnityEngine;

public class Punch : MonoBehaviour
{
	private InputManager inman;

	public FistType type;

	private string hitter;

	private float damage;

	private float screenShakeMultiplier;

	private float force;

	private bool tryForExplode;

	private float cooldownCost;

	public bool ready;

	[HideInInspector]
	public Animator anim;

	private SkinnedMeshRenderer smr;

	private Revolver rev;

	private AudioSource aud;

	private GameObject camObj;

	private CameraController cc;

	private RaycastHit hit;

	public LayerMask deflectionLayerMask;

	public LayerMask ignoreEnemyTrigger;

	public LayerMask environmentMask;

	private NewMovement nmov;

	private TrailRenderer tr;

	private Light parryLight;

	private GameObject currentDustParticle;

	public GameObject dustParticle;

	public AudioSource normalHit;

	public AudioSource heavyHit;

	public AudioSource specialHit;

	private StyleHUD shud;

	private StatsManager sman;

	public bool holding;

	public Transform holder;

	public ItemIdentifier heldItem;

	private bool hasHeldItem;

	private FistControl fc;

	private bool shopping;

	private int shopRequests;

	public GameObject parriedProjectileHitObject;

	private ProjectileParryZone ppz;

	private bool returnToOrigRot;

	public GameObject blastWave;

	private bool holdingInput;

	public GameObject shell;

	public Transform shellEjector;

	private AudioSource ejectorAud;

	private bool alreadyBoostedProjectile;

	private bool ignoreDoublePunch;

	public bool hitSomething;

	public bool parriedSomething;

	public int activeFrames;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	public void ResetHeldState()
	{
	}

	public void ForceThrow()
	{
	}

	public void PlaceHeldObject(ItemPlaceZone[] placeZones, Transform target)
	{
	}

	public void ResetHeldItemPosition()
	{
	}

	public void ForceHold(ItemIdentifier itid)
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void PunchStart()
	{
	}

	private void ActiveStart()
	{
	}

	private void FixedUpdate()
	{
	}

	private void ActiveFrame(bool firstFrame = false)
	{
	}

	private bool CheckForProjectile(Transform target, bool canProjectileBoost = false)
	{
		return false;
	}

	public void CoinFlip()
	{
	}

	private void ActiveEnd()
	{
	}

	public void ResetFistRotation()
	{
	}

	private void PunchEnd()
	{
	}

	private void ReadyToPunch()
	{
	}

	private void PunchSuccess(Vector3 point, Transform target)
	{
	}

	public void Parry(bool hook = false, EnemyIdentifier eid = null, string customParryText = "")
	{
	}

	private void ParryProjectile(Projectile proj)
	{
	}

	public void BlastCheck()
	{
	}

	public void Eject()
	{
	}

	public void Hide()
	{
	}

	public void ShopMode()
	{
	}

	public void StopShop()
	{
	}

	public void EquipAnimation()
	{
	}

	private void AltHit(Transform target)
	{
	}

	public void CancelAttack()
	{
	}

	public static Vector3 GetParryLookTarget()
	{
		return default(Vector3);
	}
}
