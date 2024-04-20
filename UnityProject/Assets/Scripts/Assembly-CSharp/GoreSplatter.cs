using UnityEngine;

public class GoreSplatter : MonoBehaviour
{
	public BSType bloodSplatterType;

	private Rigidbody rb;

	private Vector3 direction;

	private float force;

	private bool goreOver;

	private int touchedCollisions;

	private Vector3 defaultScale;

	private bool freezeGore;

	private bool foundParent;

	private Vector3 startPos;

	private bool detectCollisions;

	private void OnEnable()
	{
	}

	public void Repool()
	{
	}

	private void SlowUpdate()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void OnCollisionExit(Collision other)
	{
	}

	private void StopGore()
	{
	}
}
