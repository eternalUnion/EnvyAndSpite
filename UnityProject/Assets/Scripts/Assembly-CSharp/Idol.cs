using UnityEngine;

public class Idol : MonoBehaviour
{
	public EnemyIdentifier overrideTarget;

	public bool activeWhileWaitingForOverride;

	[HideInInspector]
	public EnemyIdentifier target;

	private int difficulty;

	[SerializeField]
	private LineRenderer beam;

	private Vector3 beamOffset;

	[SerializeField]
	private GameObject deathParticle;

	private bool dead;

	private EnemyIdentifier eid;

	[HideInInspector]
	public bool damageBuffing;

	[HideInInspector]
	public bool speedBuffing;

	private void Start()
	{
	}

	private void UpdateBuff()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void SlowUpdate()
	{
	}

	public void PickNewTarget(bool ignoreIfAlreadyTargeting = true)
	{
	}

	public void Death()
	{
	}

	private void ChangeTarget(EnemyIdentifier newTarget)
	{
	}

	public void ChangeOverrideTarget(EnemyIdentifier eid)
	{
	}
}
