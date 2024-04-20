using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
	[HideInInspector]
	public Dictionary<Rigidbody, int> rbs;

	private HashSet<Collider> contSplashables;

	private HashSet<Rigidbody> rbsToRemove;

	private List<Collider> colsToRemove;

	private Dictionary<Collider, int> enemiesToCheck;

	private HashSet<Collider> enemiesToRemove;

	private HashSet<GameObject> bubblesEffects;

	private Dictionary<Rigidbody, Collider> onDisableRemove;

	public GameObject bubblesParticle;

	public GameObject splash;

	public GameObject smallSplash;

	private Dictionary<Collider, GameObject> colliderToSplashMap;

	private Collider[] colliders;

	public Color clr;

	private bool inWater;

	private int waterRequests;

	public bool notWet;

	private UnderwaterController currentUwc;

	public List<Collider> enteredColliders;

	[Header("Optional, for fishing")]
	public FishDB fishDB;

	public Transform overrideFishingPoint;

	public FishObject[] attractFish;

	public bool simplifyWaterProcessing;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void FixedUpdate()
	{
	}

	private void CheckEnemies()
	{
	}

	private void RigidBodyForces()
	{
	}

	private void CleanSplashables()
	{
	}

	private void UpdateSplashes()
	{
	}

	private void SlowUpdate()
	{
	}

	private void OnDisable()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void Enter(Collider other)
	{
	}

	private void AddRigidbody(Rigidbody rb, Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	public void Exit(Collider other)
	{
	}

	private void RemoveRigidbody(Rigidbody rb, Collider other)
	{
	}

	public void EnterDryZone(Collider other)
	{
	}

	public void ExitDryZone(Collider other)
	{
	}

	private Vector3 GetClosestPointOnSurface(Collider target, out bool didHit)
	{
		didHit = default(bool);
		return default(Vector3);
	}
}
