using UnityEngine;

public class DoorBlocker : MonoBehaviour
{
	private AudioSource aud;

	private Door blockedDoor;

	public bool openOnDestroy;

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void Collision(Collider col)
	{
	}

	private void OnDestroy()
	{
	}
}
