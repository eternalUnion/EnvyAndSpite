using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

public class GameState
{
	public string key;

	private bool tracked;

	public LockMode playerInputLock;

	public LockMode cameraInputLock;

	public LockMode cursorLock;

	public float? timerModifier;

	public int priority;

	[CanBeNull]
	public GameObject trackedObject
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[CanBeNull]
	public GameObject[] trackedObjects
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public GameState(string key, GameObject trackedObject)
	{
	}

	public GameState(string key, GameObject[] trackedObjects)
	{
	}

	public GameState(string key)
	{
	}

	public bool IsValid()
	{
		return false;
	}
}
