using System.Collections.Generic;
using UnityEngine;

public class DryZoneController : MonoSingleton<DryZoneController>
{
	public List<Water> waters;

	public List<Collider> colliders;

	public List<int> colliderCalls;

	public List<DryZone> dryZones;

	public void AddCollider(Collider other)
	{
	}

	public void RemoveCollider(Collider other)
	{
	}

	public DryZoneController()
	{

	}
}
