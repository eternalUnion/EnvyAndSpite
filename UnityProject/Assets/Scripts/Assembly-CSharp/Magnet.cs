using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
	private List<Rigidbody> affectedRbs;

	private List<Rigidbody> removeRbs;

	private List<EnemyIdentifier> eids;

	private List<Rigidbody> eidRbs;

	public List<EnemyIdentifier> ignoredEids;

	public bool onEnemy;

	public List<Magnet> connectedMagnets;

	public List<Rigidbody> sawblades;

	public List<Rigidbody> rockets;

	private SphereCollider col;

	public float strength;

	private LayerMask lmask;

	private RaycastHit rhit;

	[SerializeField]
	private float maxWeight;

	private TimeBomb tb;

	[HideInInspector]
	public float health;

	private float maxWeightFinal => 0f;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void Launch()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	public void ConnectMagnets(Magnet target)
	{
	}

	public void DisconnectMagnets(Magnet target)
	{
	}

	public void ExitEnemy(EnemyIdentifier eid)
	{
	}

	private void Update()
	{
	}
}
