using System;
using UnityEngine;

public class KeepInBounds : MonoBehaviour
{
	[Serializable]
	private enum UpdateMode
	{
		None = 0,
		Update = 1,
		FixedUpdate = 2,
		LateUpdate = 3
	}

	[SerializeField]
	private bool useColliderCenter;

	[SerializeField]
	private float maxConsideredDistance;

	[SerializeField]
	private UpdateMode updateMode;

	private Vector3 previousTracedPosition;

	private Vector3 previousRealPosition;

	private Collider col;

	private Vector3 CurrentPosition => default(Vector3);

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	public void ForceApproveNewPosition()
	{
	}

	public void ValidateMove()
	{
	}
}
