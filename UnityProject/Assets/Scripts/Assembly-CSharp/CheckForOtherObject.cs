using UnityEngine;
using UnityEngine.Events;

public class CheckForOtherObject : MonoBehaviour
{
	public GameObject target;

	public bool disableSelf;

	public UnityEvent onOtherObjectFound;

	private void Start()
	{
	}
}
