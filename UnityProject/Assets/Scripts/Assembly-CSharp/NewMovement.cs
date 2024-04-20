using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
public class NewMovement : MonoSingleton<NewMovement>, IPortalTraveller
{
	[HideInInspector]
	public bool modNoDashSlide;

	[HideInInspector]
	public bool modNoJump;

	[HideInInspector]
	public float modForcedFrictionMultip;

	private InputManager inman;

	[HideInInspector]
	public AssistController asscon;

	public float walkSpeed;

	public float jumpPower;

	public float airAcceleration;

	public float wallJumpPower;

	private bool jumpCooldown;

	private bool falling;

	[HideInInspector]
	public Rigidbody rb;

	private Vector3 movementDirection;

	private Vector3 movementDirection2;

	private Vector3 airDirection;

	public float timeBetweenSteps;

	private float stepTime;

	private int currentStep;

	[HideInInspector]
	public Animator anim;

	private Quaternion tempRotation;

	private GameObject forwardPoint;

	public GroundCheck gc;

	public GroundCheck slopeCheck;

	private WallCheck wc;

	private PlayerAnimations pa;

	private Vector3 wallJumpPos;

	public int currentWallJumps;

	private AudioSource aud;

	private AudioSource aud2;

	private AudioSource aud3;

	private int currentSound;

	public AudioClip jumpSound;

	public AudioClip landingSound;

	public AudioClip finalWallJump;

	public bool walking;

	public int hp;

	public float antiHp;

	private float antiHpCooldown;

	public Image hurtScreen;

	private AudioSource hurtAud;

	private Color hurtColor;

	private Color currentColor;

	private bool hurting;

	public bool dead;

	public bool endlessMode;

	public Image blackScreen;

	private Color blackColor;

	public Text youDiedText;

	private Color youDiedColor;

	public FlashImage hpFlash;

	public FlashImage antiHpFlash;

	private AudioSource greenHpAud;

	private float currentAllPitch;

	private float currentAllVolume;

	public bool boost;

	public Vector3 dodgeDirection;

	private float boostLeft;

	private float dashStorage;

	public float boostCharge;

	public AudioClip dodgeSound;

	public CameraController cc;

	public GameObject staminaFailSound;

	public GameObject screenHud;

	private Vector3 hudOriginalPos;

	public GameObject dodgeParticle;

	public GameObject scrnBlood;

	private Canvas fullHud;

	public GameObject hudCam;

	private Vector3 camOriginalPos;

	private RigidbodyConstraints defaultRBConstraints;

	private GameObject revolver;

	private StyleHUD shud;

	public GameObject scrapePrefab;

	private GameObject scrapeParticle;

	public LayerMask lmask;

	public StyleCalculator scalc;

	public bool activated;

	public int gamepadFreezeCount;

	private float fallSpeed;

	public bool jumping;

	private float fallTime;

	public GameObject impactDust;

	public GameObject fallParticle;

	private GameObject currentFallParticle;

	[HideInInspector]
	public CapsuleCollider playerCollider;

	public bool sliding;

	private float slideSafety;

	public GameObject slideParticle;

	private GameObject currentSlideParticle;

	public GameObject slideScrapePrefab;

	private GameObject slideScrape;

	private Vector3 slideMovDirection;

	public GameObject slideStopSound;

	private bool crouching;

	public bool standing;

	public bool rising;

	private bool slideEnding;

	private Vector3 groundCheckPos;

	private GunControl gunc;

	public float currentSpeed;

	private FistControl punch;

	public GameObject dashJumpSound;

	public bool slowMode;

	public Vector3 pushForce;

	private float slideLength;

	[HideInInspector]
	public float longestSlide;

	private float preSlideSpeed;

	private float preSlideDelay;

	public bool quakeJump;

	public GameObject quakeJumpSound;

	[HideInInspector]
	public bool exploded;

	[HideInInspector]
	public float safeExplosionLaunchCooldown;

	private float clingFade;

	public bool stillHolding;

	public float slamForce;

	private bool slamStorage;

	private bool launched;

	private int difficulty;

	[HideInInspector]
	public int sameCheckpointRestarts;

	public CustomGroundProperties groundProperties;

	[HideInInspector]
	public int rocketJumps;

	[HideInInspector]
	public Grenade ridingRocket;

	[HideInInspector]
	public int rocketRides;

	public Dictionary<IPortalTraveller, GameObject> cloneDict;

	public Light pointLight;

	public Vector3 teleportPoint => default(Vector3);

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	public AudioSource DuplicateDetachWhoosh()
	{
		return null;
	}

	public AudioSource RestoreWhoosh()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Move()
	{
	}

	private void Dodge()
	{
	}

	public void Jump()
	{
	}

	private void WallJump()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	public void Launch(Vector3 direction)
	{
	}

	public void LaunchFromPoint(Vector3 position, float strength, float maxDistance = 1f)
	{
	}

	public void Slamdown(float strength)
	{
	}

	private void JumpReady()
	{
	}

	public void FakeHurt(bool silent = false)
	{
	}

	public void GetHurt(int damage, bool invincible, float scoreLossMultiplier = 1f, bool explosion = false, bool instablack = false, float hardDamageMultiplier = 1f, bool ignoreInvincibility = false)
	{
	}

	public void ForceAntiHP(float amount, bool silent = false, bool dontOverwriteHp = false, bool addToCooldown = true)
	{
	}

	public void ForceAddAntiHP(float amount, bool silent = false, bool dontOverwriteHp = false, bool addToCooldown = true)
	{
	}

	public void GetHealth(int health, bool silent)
	{
	}

	public void SuperCharge()
	{
	}

	public void Respawn()
	{
	}

	public void ResetHardDamage()
	{
	}

	private void NotJumping()
	{
	}

	private void StartSlide()
	{
	}

	public void StopSlide()
	{
	}

	public void EmptyStamina()
	{
	}

	public void FullStamina()
	{
	}

	public void DeactivatePlayer()
	{
	}

	public void ActivatePlayer()
	{
	}

	public void StopMovement()
	{
	}

	public void DeactivateMovement()
	{
	}

	public void ReactivateMovement()
	{
	}

	public void LockMovementAxes()
	{
	}

	public void UnlockMovementAxes()
	{
	}

	public GameObject CreateClone()
	{
		return null;
	}

	public void Teleport(Portal inPortal, Portal outPortal)
	{
	}

	public NewMovement()
	{

	}
}
