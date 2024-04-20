using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ScreenZone : MonoBehaviour
{
	protected bool inZone;

	protected bool touchMode;

	private GunControl gc;

	private FistControl pun;

	[SerializeField]
	private AudioSource music;

	[SerializeField]
	private float angleLimit;

	[SerializeField]
	private Transform angleSourceOverride;

	[Space]
	[SerializeField]
	protected UnityEvent onEnterZone;

	[SerializeField]
	protected UnityEvent onExitZone;

	private GraphicRaycaster raycaster;

	private void OnDisable()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	public virtual void UpdatePlayerState(bool active)
	{
	}

	protected virtual void Update()
	{
	}
}
