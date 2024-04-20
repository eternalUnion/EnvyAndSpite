using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class InputActions : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
{
	public struct UIActions
	{
		private InputActions m_Wrapper;

		public InputAction Navigate => null;

		public InputAction Submit => null;

		public InputAction Cancel => null;

		public InputAction Point => null;

		public InputAction Click => null;

		public InputAction ScrollWheel => null;

		public InputAction MiddleClick => null;

		public InputAction RightClick => null;

		public InputAction TrackedDevicePosition => null;

		public InputAction TrackedDeviceOrientation => null;

		public InputAction ScrollSublist => null;

		public InputAction Stats => null;

		public InputAction Pause => null;

		public bool enabled => false;

		public UIActions(InputActions wrapper)
		{
			m_Wrapper = wrapper;
		}

		public InputActionMap Get()
		{
			return null;
		}

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		public static implicit operator InputActionMap(UIActions set)
		{
			return null;
		}

		public void SetCallbacks(IUIActions instance)
		{
		}
	}

	public struct MovementActions
	{
		private InputActions m_Wrapper;

		public InputAction Move => null;

		public InputAction Look => null;

		public InputAction Dodge => null;

		public InputAction Slide => null;

		public InputAction Jump => null;

		public bool enabled => false;

		public MovementActions(InputActions wrapper)
		{
			m_Wrapper = wrapper;
		}

		public InputActionMap Get()
		{
			return null;
		}

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		public static implicit operator InputActionMap(MovementActions set)
		{
			return null;
		}

		public void SetCallbacks(IMovementActions instance)
		{
		}
	}

	public struct FistActions
	{
		private InputActions m_Wrapper;

		public InputAction ChangeFist => null;

		public InputAction Punch => null;

		public InputAction Hook => null;

		public bool enabled => false;

		public FistActions(InputActions wrapper)
		{
			m_Wrapper = wrapper;
		}

		public InputActionMap Get()
		{
			return null;
		}

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		public static implicit operator InputActionMap(FistActions set)
		{
			return null;
		}

		public void SetCallbacks(IFistActions instance)
		{
		}
	}

	public struct WeaponActions
	{
		private InputActions m_Wrapper;

		public InputAction PrimaryFire => null;

		public InputAction SecondaryFire => null;

		public InputAction ChangeVariation => null;

		public InputAction Slot0 => null;

		public InputAction Slot1 => null;

		public InputAction Slot2 => null;

		public InputAction Slot3 => null;

		public InputAction Slot4 => null;

		public InputAction Slot5 => null;

		public InputAction Slot6 => null;

		public InputAction Slot7 => null;

		public InputAction Slot8 => null;

		public InputAction Slot9 => null;

		public InputAction NextWeapon => null;

		public InputAction PreviousWeapon => null;

		public InputAction LastWeapon => null;

		public InputAction WheelLook => null;

		public bool enabled => false;

		public WeaponActions(InputActions wrapper)
		{
			m_Wrapper = wrapper;
		}

		public InputActionMap Get()
		{
			return null;
		}

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		public static implicit operator InputActionMap(WeaponActions set)
		{
			return null;
		}

		public void SetCallbacks(IWeaponActions instance)
		{
		}
	}

	public interface IUIActions
	{
		void OnNavigate(InputAction.CallbackContext context);

		void OnSubmit(InputAction.CallbackContext context);

		void OnCancel(InputAction.CallbackContext context);

		void OnPoint(InputAction.CallbackContext context);

		void OnClick(InputAction.CallbackContext context);

		void OnScrollWheel(InputAction.CallbackContext context);

		void OnMiddleClick(InputAction.CallbackContext context);

		void OnRightClick(InputAction.CallbackContext context);

		void OnTrackedDevicePosition(InputAction.CallbackContext context);

		void OnTrackedDeviceOrientation(InputAction.CallbackContext context);

		void OnScrollSublist(InputAction.CallbackContext context);

		void OnStats(InputAction.CallbackContext context);

		void OnPause(InputAction.CallbackContext context);
	}

	public interface IMovementActions
	{
		void OnMove(InputAction.CallbackContext context);

		void OnLook(InputAction.CallbackContext context);

		void OnDodge(InputAction.CallbackContext context);

		void OnSlide(InputAction.CallbackContext context);

		void OnJump(InputAction.CallbackContext context);
	}

	public interface IFistActions
	{
		void OnChangeFist(InputAction.CallbackContext context);

		void OnPunch(InputAction.CallbackContext context);

		void OnHook(InputAction.CallbackContext context);
	}

	public interface IWeaponActions
	{
		void OnPrimaryFire(InputAction.CallbackContext context);

		void OnSecondaryFire(InputAction.CallbackContext context);

		void OnChangeVariation(InputAction.CallbackContext context);

		void OnSlot0(InputAction.CallbackContext context);

		void OnSlot1(InputAction.CallbackContext context);

		void OnSlot2(InputAction.CallbackContext context);

		void OnSlot3(InputAction.CallbackContext context);

		void OnSlot4(InputAction.CallbackContext context);

		void OnSlot5(InputAction.CallbackContext context);

		void OnSlot6(InputAction.CallbackContext context);

		void OnSlot7(InputAction.CallbackContext context);

		void OnSlot8(InputAction.CallbackContext context);

		void OnSlot9(InputAction.CallbackContext context);

		void OnNextWeapon(InputAction.CallbackContext context);

		void OnPreviousWeapon(InputAction.CallbackContext context);

		void OnLastWeapon(InputAction.CallbackContext context);

		void OnWheelLook(InputAction.CallbackContext context);
	}

	private readonly InputActionMap m_UI;

	private IUIActions m_UIActionsCallbackInterface;

	private readonly InputAction m_UI_Navigate;

	private readonly InputAction m_UI_Submit;

	private readonly InputAction m_UI_Cancel;

	private readonly InputAction m_UI_Point;

	private readonly InputAction m_UI_Click;

	private readonly InputAction m_UI_ScrollWheel;

	private readonly InputAction m_UI_MiddleClick;

	private readonly InputAction m_UI_RightClick;

	private readonly InputAction m_UI_TrackedDevicePosition;

	private readonly InputAction m_UI_TrackedDeviceOrientation;

	private readonly InputAction m_UI_ScrollSublist;

	private readonly InputAction m_UI_Stats;

	private readonly InputAction m_UI_Pause;

	private readonly InputActionMap m_Movement;

	private IMovementActions m_MovementActionsCallbackInterface;

	private readonly InputAction m_Movement_Move;

	private readonly InputAction m_Movement_Look;

	private readonly InputAction m_Movement_Dodge;

	private readonly InputAction m_Movement_Slide;

	private readonly InputAction m_Movement_Jump;

	private readonly InputActionMap m_Fist;

	private IFistActions m_FistActionsCallbackInterface;

	private readonly InputAction m_Fist_ChangeFist;

	private readonly InputAction m_Fist_Punch;

	private readonly InputAction m_Fist_Hook;

	private readonly InputActionMap m_Weapon;

	private IWeaponActions m_WeaponActionsCallbackInterface;

	private readonly InputAction m_Weapon_PrimaryFire;

	private readonly InputAction m_Weapon_SecondaryFire;

	private readonly InputAction m_Weapon_ChangeVariation;

	private readonly InputAction m_Weapon_Slot0;

	private readonly InputAction m_Weapon_Slot1;

	private readonly InputAction m_Weapon_Slot2;

	private readonly InputAction m_Weapon_Slot3;

	private readonly InputAction m_Weapon_Slot4;

	private readonly InputAction m_Weapon_Slot5;

	private readonly InputAction m_Weapon_Slot6;

	private readonly InputAction m_Weapon_Slot7;

	private readonly InputAction m_Weapon_Slot8;

	private readonly InputAction m_Weapon_Slot9;

	private readonly InputAction m_Weapon_NextWeapon;

	private readonly InputAction m_Weapon_PreviousWeapon;

	private readonly InputAction m_Weapon_LastWeapon;

	private readonly InputAction m_Weapon_WheelLook;

	private int m_KeyboardMouseSchemeIndex;

	private int m_GamepadSchemeIndex;

	public InputActionAsset asset
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public InputBinding? bindingMask
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ReadOnlyArray<InputDevice>? devices
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ReadOnlyArray<InputControlScheme> controlSchemes => default(ReadOnlyArray<InputControlScheme>);

	public IEnumerable<InputBinding> bindings => null;

	public UIActions UI => default(UIActions);

	public MovementActions Movement => default(MovementActions);

	public FistActions Fist => default(FistActions);

	public WeaponActions Weapon => default(WeaponActions);

	public InputControlScheme KeyboardMouseScheme => default(InputControlScheme);

	public InputControlScheme GamepadScheme => default(InputControlScheme);

	public void Dispose()
	{
	}

	public bool Contains(InputAction action)
	{
		return false;
	}

	public IEnumerator<InputAction> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public void Enable()
	{
	}

	public void Disable()
	{
	}

	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
	{
		return null;
	}

	public int FindBinding(InputBinding bindingMask, out InputAction action)
	{
		action = null;
		return 0;
	}
}
