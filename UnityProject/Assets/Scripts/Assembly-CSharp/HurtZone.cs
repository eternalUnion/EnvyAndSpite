using System.Collections.Generic;
using Sandbox;
using UnityEngine;
using UnityEngine.Serialization;

public class HurtZone : MonoBehaviour, IAlter, IAlterOptions<float>
{
	public EnviroDamageType damageType;

	public bool trigger;

	public float bounceForce;

	private Collider col;

	public float hurtCooldown;

	[FormerlySerializedAs("damage")]
	public float setDamage;

	public float hardDamageMultiplier;

	public float enemyDamageOverride;

	private int hurtingPlayer;

	private float playerHurtCooldown;

	private List<EnemyIdentifier> hurtList;

	private List<int> limbsAmount;

	private List<float> hurtTimes;

	private List<EnemyIdentifier> toRemove;

	public GameObject hurtParticle;

	private int difficulty;

	private float damageMultiplier;

	private NewMovement newMovement;

	private PlayerTracker playerTracker;

	private PlatformerMovement platformerMovement;

	public List<EnemyType> ignoredEnemyTypes;

	private float damage => 0f;

	public string alterKey => null;

	public string alterCategoryName => null;

	public AlterOption<float>[] options => null;

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Enter(Collider other)
	{
	}

	private void Exit(Collider other)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void OnCollisionExit(Collision other)
	{
	}
}
