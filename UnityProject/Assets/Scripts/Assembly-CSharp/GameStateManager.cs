using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[DefaultExecutionOrder(-500)]
public class GameStateManager : MonoBehaviour
{
	public CustomGameDetails currentCustomGame;

	private readonly Dictionary<string, GameState> activeStates;

	private readonly List<string> stateOrder;

	public static GameStateManager Instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Vector3 defaultGravity
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

	public bool CameraLocked
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool PlayerInputLocked
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool CursorLocked
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float TimerModifier
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static bool CanSubmitScores => false;

	public static bool ShowLeaderboards => false;

	public bool IsStateActive(string stateKey)
	{
		return false;
	}

	public void RegisterState(GameState newState)
	{
	}

	public void PopState(string stateKey)
	{
	}

	public void ResetGravity()
	{
	}

	private void EvaluateState()
	{
	}

	private void Update()
	{
	}

	private void Awake()
	{
	}
}
