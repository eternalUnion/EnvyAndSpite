using UnityEngine;

public class ItemTrigger : MonoBehaviour
{
	public ItemType targetType;

	public bool oneTime;

	private bool activated;

	public bool destroyActivator;

	public bool dontRequireItemLayer;

	public UltrakillEvent onEvent;

	private void OnTriggerEnter(Collider other)
	{
	}
}
