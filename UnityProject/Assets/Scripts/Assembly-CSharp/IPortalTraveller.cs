using UnityEngine;

public interface IPortalTraveller
{
	Vector3 teleportPoint { get; }

	GameObject CreateClone();

	void Teleport(Portal inPortal, Portal outPortal);
}
