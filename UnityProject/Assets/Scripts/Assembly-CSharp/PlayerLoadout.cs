using UnityEngine;
using UnityEngine.Serialization;

public class PlayerLoadout : MonoBehaviour, IPlaceholdableComponent
{
	[FormerlySerializedAs("forceLoadout")]
	public bool forceStartLoadout;

	public ForcedLoadout loadout;

	public void WillReplace(GameObject oldObject, GameObject newObject, bool isSelfBeingReplaced)
	{
	}

	public void SetLoadout()
	{
	}
}
