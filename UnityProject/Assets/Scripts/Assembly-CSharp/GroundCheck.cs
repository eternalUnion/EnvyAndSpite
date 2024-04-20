using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
	public bool slopeCheck;

	public bool onGround;

	public bool touchingGround;

	public bool canJump;

	public bool heavyFall;

	public GameObject shockwave;

	public float superJumpChance;

	public float extraJumpChance;

	public TimeSince sinceLastGrounded;

	private NewMovement nmov;

	private PlayerMovementParenting pmov;

	private Collider currentEnemyCol;

	public int forcedOff;

	private LayerMask waterMask;

	public List<Collider> cols;

	private void Start()
	{
	}

	private void OnEnable()
	{
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

	private void OnTriggerExit(Collider other)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void BounceOnWater(Collider other)
	{
	}

	public void ForceOff()
	{
	}

	public void StopForceOff()
	{
	}

	public bool ColliderIsCheckable(Collider col)
	{
		return false;
	}

	public bool ColliderIsStillUsable(Collider col)
	{
		return false;
	}
}
