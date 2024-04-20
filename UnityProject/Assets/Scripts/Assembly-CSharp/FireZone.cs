using UnityEngine;

public class FireZone : MonoBehaviour
{
	public FlameSource source;

	private Streetcleaner sc;

	private float playerHurtCooldown;

	private NewMovement nmov;

	private void Update()
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}
}
