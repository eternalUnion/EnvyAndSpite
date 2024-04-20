using System.Collections.Generic;
using UnityEngine;

public class LeviathanHead : MonoBehaviour
{
	[HideInInspector]
	public bool active;

	private Animator anim;

	[SerializeField]
	private Transform shootPoint;

	private bool projectileBursting;

	private int projectilesLeftInBurst;

	private float projectileBurstCooldown;

	public float projectileSpreadAmount;

	public Transform tracker;

	private List<Transform> trackerBones;

	[SerializeField]
	private Transform tailBone;

	private Transform[] tailBones;

	private bool inAction;

	private float attackCooldown;

	public bool lookAtPlayer;

	private Quaternion defaultHeadRotation;

	private Quaternion previousHeadRotation;

	private bool notAtDefaultHeadRotation;

	private bool trackerOverrideAnimation;

	private bool trackerIgnoreLimits;

	private float cantTurnToPlayer;

	private float headRotationSpeedMultiplier;

	private bool freezeTail;

	private Vector3[] defaultTailPositions;

	private Quaternion[] defaultTailRotations;

	private bool rotateBody;

	private Quaternion defaultBodyRotation;

	private Vector3 defaultPosition;

	private bool bodyRotationOverride;

	private Vector3 bodyRotationOverrideTarget;

	[SerializeField]
	private SwingCheck2 biteSwingCheck;

	public Vector3[] spawnPositions;

	private int previousSpawnPosition;

	private int previousAttack;

	private int recentAttacks;

	[HideInInspector]
	public LeviathanController lcon;

	[SerializeField]
	private UltrakillEvent onRoar;

	[SerializeField]
	private AudioSource projectileWindupSound;

	[SerializeField]
	private AudioSource biteWindupSound;

	[SerializeField]
	private AudioSource swingSound;

	[SerializeField]
	private GameObject warningFlash;

	private void Start()
	{
	}

	public void SetSpeed()
	{
	}

	private void OnEnable()
	{
	}

	private void ResetDefaults()
	{
	}

	private void OnDisable()
	{
	}

	private void LateUpdate()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Descend()
	{
	}

	private void DescendEnd()
	{
	}

	public void ChangePosition()
	{
	}

	private void Ascend()
	{
	}

	private void StartHeadTracking()
	{
	}

	private void StartBodyTracking()
	{
	}

	private void Bite()
	{
	}

	private void BiteStopTracking()
	{
	}

	private void BiteDamageStart()
	{
	}

	public void BiteDamageStop()
	{
	}

	private void BiteResetRotation()
	{
	}

	private void BiteEnd()
	{
	}

	private void ProjectileBurst()
	{
	}

	private void ProjectileBurstStart()
	{
	}

	private void StopAction()
	{
	}

	private void Roar()
	{
	}

	private void BigSplash()
	{
	}
}
