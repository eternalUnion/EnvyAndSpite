using System.Collections.Generic;
using UnityEngine;

public class ContinuousBeam : MonoBehaviour
{
	public EnemyTarget target;

	private LineRenderer lr;

	private LayerMask environmentMask;

	private LayerMask hitMask;

	public bool canHitPlayer;

	public bool canHitEnemy;

	public bool ignoreInvincibility;

	public float beamWidth;

	public bool enemy;

	public EnemyType safeEnemyType;

	public float damage;

	private float playerCooldown;

	private List<EnemyIdentifier> hitEnemies;

	private List<float> enemyCooldowns;

	public GameObject impactEffect;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
