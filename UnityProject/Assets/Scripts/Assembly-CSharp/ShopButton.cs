using UnityEngine;

public class ShopButton : MonoBehaviour
{
	public bool deactivated;

	public bool failure;

	public GameObject clickSound;

	public GameObject failSound;

	public GameObject[] toActivate;

	public GameObject[] toDeactivate;

	public VariationInfo variationInfo;

	private ControllerPointer pointer;

	private void Awake()
	{
	}

	private void OnPointerClick()
	{
	}
}
