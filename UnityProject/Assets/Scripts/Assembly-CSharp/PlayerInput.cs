using System;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class PlayerInput
{
	public InputActions Actions;

	public InputActionState Move;

	public InputActionState Look;

	public InputActionState WheelLook;

	public InputActionState Punch;

	public InputActionState Hook;

	public InputActionState Fire1;

	public InputActionState Fire2;

	public InputActionState Jump;

	public InputActionState Slide;

	public InputActionState Dodge;

	public InputActionState ChangeFist;

	public InputActionState ChangeVariation;

	public InputActionState NextWeapon;

	public InputActionState PrevWeapon;

	public InputActionState LastWeapon;

	public InputActionState Pause;

	public InputActionState Stats;

	public InputActionState Slot0;

	public InputActionState Slot1;

	public InputActionState Slot2;

	public InputActionState Slot3;

	public InputActionState Slot4;

	public InputActionState Slot5;

	public InputActionState Slot6;

	public InputActionState Slot7;

	public InputActionState Slot8;

	public InputActionState Slot9;

	public Dictionary<string, Guid> actionNameToId;

	private Dictionary<string, InputBinding[]> conflicts;

	public void ValidateBindings(InputControlScheme scheme)
	{
	}

	private void RebuildActions()
	{
	}

	public InputBinding[] GetConflicts(InputBinding binding)
	{
		return null;
	}

	public void Enable()
	{
	}

	public void Disable()
	{
	}
}
