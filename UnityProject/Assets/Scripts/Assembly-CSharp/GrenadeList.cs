using System.Collections.Generic;
using UnityEngine;

public class GrenadeList : MonoSingleton<GrenadeList>
{
	public List<Grenade> grenadeList;

	public List<Cannonball> cannonballList;

	public List<Landmine> landmineList;

	public void AddGrenade(Grenade gren)
	{
	}

	public void AddCannonball(Cannonball cb)
	{
	}

	public void AddLandmine(Landmine lm)
	{
	}

	public void RemoveGrenade(Grenade gren)
	{
	}

	public void RemoveCannonball(Cannonball cb)
	{
	}

	public void RemoveLandmine(Landmine lm)
	{
	}

	public Grenade GetGrenade(Transform tf)
	{
		return null;
	}

	public Cannonball GetCannonball(Transform tf)
	{
		return null;
	}

	public Landmine GetLandmine(Transform tf)
	{
		return null;
	}

	public bool HasTransform(Transform tf)
	{
		return false;
	}

	private void Start()
	{
	}

	private void SlowUpdate()
	{
	}

	public GrenadeList()
	{

	}
}
