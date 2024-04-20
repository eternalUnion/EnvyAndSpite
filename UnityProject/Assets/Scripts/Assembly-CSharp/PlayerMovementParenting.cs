using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
public class PlayerMovementParenting : MonoSingleton<PlayerMovementParenting>
{
	public Transform deltaReceiver;

	private Vector3 lastTrackedPos;

	private float lastAngle;

	private Transform playerTracker;

	[HideInInspector]
	public bool lockParent;

	private Vector3 teleportLockDelta;

	private List<Transform> trackedObjects;

	public Vector3 currentDelta
	{
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public List<Transform> TrackedObjects => null;

	private new void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	public bool IsPlayerTracking()
	{
		return false;
	}

	public bool IsObjectTracked(Transform other)
	{
		return false;
	}

	public void AttachPlayer(Transform other)
	{
	}

	public void DetachPlayer([CanBeNull] Transform other = null)
	{
	}

	private void ClearNulls()
	{
	}

	public void LockMovementParent(bool fuck)
	{
	}

	public void LockMovementParentTeleport(bool fuck)
	{
	}

	public PlayerMovementParenting()
	{

	}
}
