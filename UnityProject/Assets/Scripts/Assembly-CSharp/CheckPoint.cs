using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;

public class CheckPoint : MonoBehaviour
{
	[HideInInspector]
	public StatsManager sm;

	[HideInInspector]
	public bool activated;

	public bool forceOff;

	private bool notFirstTime;

	public GameObject toActivate;

	public GameObject[] rooms;

	public List<GameObject> roomsToInherit;

	private List<string> inheritNames;

	private List<Transform> inheritParents;

	private GameObject[] roomsPriv;

	[HideInInspector]
	public List<GameObject> defaultRooms;

	public Door[] doorsToUnlock;

	[HideInInspector]
	public List<GameObject> newRooms;

	private int i;

	private GameObject player;

	private NewMovement nm;

	private float tempRot;

	public GameObject graphic;

	public AssetReference activateEffect;

	[HideInInspector]
	public int restartKills;

	[HideInInspector]
	public int stylePoints;

	[HideInInspector]
	public bool challengeAlreadyFailed;

	[HideInInspector]
	public bool challengeAlreadyDone;

	private StyleHUD shud;

	public bool multiUse;

	public bool dontAutoReset;

	public bool startOff;

	public bool unteleportable;

	public bool invisible;

	[HideInInspector]
	public List<int> succesfulHitters;

	[Space]
	public UnityEvent onRestart;

	[HideInInspector]
	public float additionalSpawnRotation;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public void ActivateCheckPoint()
	{
	}

	public void OnRespawn()
	{
	}

	public void ResetRoom()
	{
	}

	public void UpdateRooms()
	{
	}

	public void InheritRoom(GameObject targetRoom)
	{
	}

	public void ReactivateCheckpoint()
	{
	}

	public void ReactivationEffect()
	{
	}

	public void ApplyCurrentStyleAndKills()
	{
	}

	public void ApplyCurrentKills()
	{
	}

	public void ApplyCurrentStyle()
	{
	}

	public void AddCustomKill()
	{
	}

	public void ChangeSpawnRotation(float degrees)
	{
	}

	public void SetInvisibility(bool state)
	{
	}

	public void SetForceOff(bool state)
	{
	}
}
