using System.Collections.Generic;
using UnityEngine;

public class Bloodsplatter : MonoBehaviour
{
	public BSType bloodSplatterType;

	[HideInInspector]
	public ParticleSystem part;

	public List<ParticleCollisionEvent> collisionEvents;

	public GameObject bloodStain;

	private GameObject bldstn;

	private int i;

	private AudioSource[] bloodStainAud;

	private AudioSource aud;

	private int eidID;

	private SpriteRenderer sr;

	private MeshRenderer mr;

	private NewMovement nmov;

	public int hpAmount;

	private SphereCollider col;

	public bool hpOnParticleCollision;

	private OptionsManager opm;

	public bool halfChance;

	public bool ready;

	private GoreZone gz;

	public bool underwater;

	private MaterialPropertyBlock propertyBlock;

	private bool canCollide;

	[HideInInspector]
	public EnemyIdentifier eid
	{
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void Repool()
	{
	}

	private void OnParticleCollision(GameObject other)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void DisableCollider()
	{
	}

	public void GetReady()
	{
	}
}
