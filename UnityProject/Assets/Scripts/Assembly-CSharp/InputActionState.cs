using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;

public class InputActionState
{
	public InputAction Action
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public float PerformedTime
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

	public int PerformedFrame
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int CanceledFrame
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsPressed
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

	public string LastUsedBinding
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

	public float HoldTime => 0f;

	public bool WasPerformedThisFrame => false;

	public bool WasCanceledThisFrame => false;

	public InputActionState(InputAction action)
	{
	}

	private void OnTriggered(InputAction.CallbackContext context)
	{
	}

	public TValue ReadValue<TValue>() where TValue : struct
	{
		return default(TValue);
	}
}
