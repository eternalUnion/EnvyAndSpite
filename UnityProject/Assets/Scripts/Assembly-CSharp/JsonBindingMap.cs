using System.Collections.Generic;
using UnityEngine.InputSystem;

public class JsonBindingMap
{
	public string controlScheme;

	public Dictionary<string, List<JsonBinding>> modifiedActions;

	public static JsonBindingMap From(InputActionAsset asset, InputControlScheme scheme)
	{
		return null;
	}

	public static JsonBindingMap From(InputActionAsset asset, InputActionAsset baseAsset, InputControlScheme scheme)
	{
		return null;
	}

	public void ApplyTo(InputActionAsset asset)
	{
	}

	public void AddAction(InputAction action)
	{
	}
}
