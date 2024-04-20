using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
	[HideInInspector]
	public bool infoSet;

	public Vector3[] relativePoints;

	[HideInInspector]
	public Vector3 originalPosition;

	[HideInInspector]
	public Vector3 currentPosition;

	[HideInInspector]
	public Vector3 targetPosition;

	[HideInInspector]
	public int currentPoint;

	public bool useRigidbody;

	private Rigidbody rb;

	public float speed;

	public bool ease;

	public bool reverseAtEnd;

	public bool stopAtEnd;

	[HideInInspector]
	public bool forward;

	[HideInInspector]
	public bool moving;

	public float startOffset;

	public float moveDelay;

	[HideInInspector]
	public AudioSource aud;

	[HideInInspector]
	public float origPitch;

	public AudioClip moveSound;

	public AudioClip stopSound;

	public UltrakillEvent[] onReachPoint;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void NextPoint()
	{
	}
}
