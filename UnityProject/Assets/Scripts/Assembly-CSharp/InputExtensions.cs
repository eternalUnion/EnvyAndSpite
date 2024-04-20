using UnityEngine.InputSystem;

public static class InputExtensions
{
	public static void WipeAction(this InputAction action, string controlScheme)
	{
	}

	public static bool IsActionEqual(this InputAction action, InputAction baseAction, string controlScheme = null)
	{
		return false;
	}

	public static bool IsBindingEqual(this InputBinding binding, InputBinding other)
	{
		return false;
	}

	public static bool HasGroup(this InputBinding binding, string group)
	{
		return false;
	}

	private static bool AreStringsEqual(string str1, string str2)
	{
		return false;
	}
}
