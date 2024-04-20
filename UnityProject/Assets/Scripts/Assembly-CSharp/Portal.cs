using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
	public Portal exit;

	public PortalRadius portalRadius;

	public Material portalMaterial;

	public Camera portalCamera;

	public Renderer renderer;

	private Resolution resolution;

	private MaterialPropertyBlock block;

	private RenderTexture texture;

	private Plane plane;

	private Vector4 clipPlane;

	private Dictionary<IPortalTraveller, GameObject> travellerClones;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnTravellerEntered(IPortalTraveller traveller)
	{
	}

	private void OnTravellerExited(IPortalTraveller traveller)
	{
	}

	public Vector3 GetExitPoint(Vector3 point)
	{
		return default(Vector3);
	}

	public Vector3 GetExitDirection(Vector3 direction)
	{
		return default(Vector3);
	}

	public Vector3 GetExitVector(Vector3 vector)
	{
		return default(Vector3);
	}

	public Quaternion GetExitRotation(Quaternion rotation)
	{
		return default(Quaternion);
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public void UpdateCamera()
	{
	}

	public void UpdateClipPlane()
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}
}
