using System.Collections.Generic;
using DebugOverlays;
using Sandbox;
using ULTRAKILL.Cheats;
using UnityEngine;
using UnityEngine.Events;

[DefaultExecutionOrder(-500)]
public class EnemyIdentifier : MonoBehaviour, IAlter, IAlterOptions<bool>, IEnemyHealthDetails
{
	[HideInInspector]
	public Zombie zombie;

	[HideInInspector]
	public SpiderBody spider;

	[HideInInspector]
	public Machine machine;

	[HideInInspector]
	public Statue statue;

	[HideInInspector]
	public Wicked wicked;

	[HideInInspector]
	public Drone drone;

	[HideInInspector]
	public Idol idol;

	public EnemyClass enemyClass;

	public EnemyType enemyType;

	public bool spawnIn;

	public GameObject spawnEffect;

	public float health;

	[HideInInspector]
	public string hitter;

	[HideInInspector]
	public List<HitterAttribute> hitterAttributes;

	[HideInInspector]
	public List<string> hitterWeapons;

	public string[] weaknesses;

	public float[] weaknessMultipliers;

	public float totalDamageTakenMultiplier;

	public GameObject weakPoint;

	public Transform overrideCenter;

	[HideInInspector]
	public bool exploded;

	public bool dead;

	[HideInInspector]
	public DoorController usingDoor;

	public bool ignoredByEnemies;

	private EnemyIdentifierIdentifier[] limbs;

	[HideInInspector]
	public int nailsAmount;

	[HideInInspector]
	public List<Nail> nails;

	public bool useBrakes;

	public bool bigEnemy;

	public bool unbounceable;

	public bool poise;

	private bool beingZapped;

	[HideInInspector]
	public bool pulledByMagnet;

	[HideInInspector]
	public List<Magnet> stuckMagnets;

	[HideInInspector]
	public List<Harpoon> drillers;

	[HideInInspector]
	public bool underwater;

	[HideInInspector]
	public bool checkingSpawnStatus;

	public bool flying;

	public bool dontCountAsKills;

	public bool dontUnlockBestiary;

	public bool specialOob;

	public GameObject[] activateOnDeath;

	public UnityEvent onDeath;

	public UltrakillEvent onEnable;

	private BloodsplatterManager bsm;

	[HideInInspector]
	public GroundCheckEnemy gce;

	private GoreZone gz;

	private Rigidbody rb;

	private RigidbodyConstraints rbc;

	private List<GameObject> sandifiedParticles;

	[HideInInspector]
	public List<GameObject> blessingGlows;

	[HideInInspector]
	public EnemyIdentifier buffTargeter;

	public int difficultyOverride;

	[HideInInspector]
	public bool hooked;

	[HideInInspector]
	public List<Flammable> burners;

	[HideInInspector]
	public bool harpooned;

	[Header("Modifiers")]
	public bool hookIgnore;

	public bool sandified;

	public bool blessed;

	public bool puppet;

	private int blessings;

	private float puppetSpawnTimer;

	[HideInInspector]
	public Vector3 squishedScale;

	[HideInInspector]
	public Vector3 originalScale;

	private List<Renderer> puppetRenderers;

	private bool puppetSpawnIgnoringPlayer;

	private Collider[] puppetSpawnColliders;

	public float radianceTier;

	public bool healthBuff;

	public float healthBuffModifier;

	[HideInInspector]
	public int healthBuffRequests;

	public bool speedBuff;

	public float speedBuffModifier;

	[HideInInspector]
	public int speedBuffRequests;

	public bool damageBuff;

	public float damageBuffModifier;

	[HideInInspector]
	public int damageBuffRequests;

	[HideInInspector]
	public float totalSpeedModifier;

	[HideInInspector]
	public float totalDamageModifier;

	[HideInInspector]
	public float totalHealthModifier;

	[HideInInspector]
	public bool isBoss;

	[Space(10f)]
	public List<Renderer> buffUnaffectedRenderers;

	[SerializeField]
	private string overrideFullName;

	[Header("Relationships")]
	public bool ignorePlayer;

	public bool attackEnemies;

	public EnemyTarget target;

	public bool prioritizePlayerOverFallback;

	public bool prioritizeEnemiesUnlessAttacked;

	public Transform fallbackTarget;

	[HideInInspector]
	public bool madness;

	[HideInInspector]
	public TimeSince timeSinceSpawned;

	private TimeSince? timeSinceNoTarget;

	private EnemyScanner enemyScanner;

	private bool cheatCausedEnemyHate;

	private bool cheatCausedIgnorePlayer;

	private EnemyIdentifierDebugOverlay debugOverlay;

	private BossHealthBar cheatCreatedBossBar;

	[HideInInspector]
	public List<GameObject> destroyOnDeath;

	public bool IsCurrentTargetFallback => false;

	public string FullName => null;

	public float Health => 0f;

	public bool Dead => false;

	public bool Blessed => false;

	public bool AttackEnemies => false;

	public bool IgnorePlayer => false;

	public string alterKey => null;

	public string alterCategoryName => null;

	public AlterOption<bool>[] options => null;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void InitializeReferences()
	{
	}

	public bool IsTypeFriendly(EnemyIdentifier owner)
	{
		return false;
	}

	private GoreZone GetGoreZone()
	{
		return null;
	}

	public void ForceGetHealth()
	{
	}

	private void Start()
	{
	}

	private void SlowUpdate()
	{
	}

	private void Update()
	{
	}

	private void UpdateEnemyScanner()
	{
	}

	private void UpdateDebugStuff()
	{
	}

	private bool HandleTargetCheats()
	{
		return false;
	}

	private void UpdateTarget()
	{
	}

	public void SetFallbackTarget(GameObject target)
	{
	}

	public void SetOverrideCenter(Transform center)
	{
	}

	public void ResetTarget()
	{
	}

	private void UpdateModifiers()
	{
	}

	private void CheckBurners()
	{
	}

	public void DeliverDamage(GameObject target, Vector3 force, Vector3 hitPoint, float multiplier, bool tryForExplode, float critMultiplier = 0f, GameObject sourceWeapon = null, bool ignoreTotalDamageTakenMultiplier = false)
	{
	}

	private void AfterShock()
	{
	}

	public void Death()
	{
	}

	public void DestroyMagnets()
	{
	}

	public void InstaKill()
	{
	}

	public void Explode()
	{
	}

	public void Splatter(bool styleBonus = true)
	{
	}

	public void StopSplatter()
	{
	}

	public void Sandify(bool ignorePrevious = false)
	{
	}

	public void Desandify(bool visualOnly = false)
	{
	}

	public void Bless(bool ignorePrevious = false)
	{
	}

	public void Unbless(bool visualOnly = false)
	{
	}

	public void PuppetSpawn()
	{
	}

	public void BuffAll()
	{
	}

	public void UnbuffAll()
	{
	}

	public void DamageBuff(float modifier = -999f)
	{
	}

	public void DamageUnbuff()
	{
	}

	public void SpeedBuff(float modifier = -999f)
	{
	}

	public void SpeedUnbuff()
	{
	}

	public void HealthBuff(float modifier = -999f)
	{
	}

	public void HealthUnbuff()
	{
	}

	public void UpdateBuffs(bool visualsOnly = false)
	{
	}

	public static bool CheckHurtException(EnemyType attacker, EnemyType receiver, EnemyTarget attackTarget = null)
	{
		return false;
	}

	public static void FallOnEnemy(EnemyIdentifier eid)
	{
	}

	public void PlayerMarkedForDeath()
	{
	}

	public void ChangeDamageTakenMultiplier(float newMultiplier)
	{
	}

	public void SimpleDamage(float amount)
	{
	}

	public void SimpleDamageIgnoreMultiplier(float amount)
	{
	}

	public Transform GetCenter()
	{
		return null;
	}
}
