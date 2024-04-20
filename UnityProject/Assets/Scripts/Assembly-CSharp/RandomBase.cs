using System.Collections.Generic;
using UnityEngine;

public class RandomBase<T> : MonoBehaviour where T : RandomEntry, new()
{
	public bool randomizeOnEnable;

	public int toBeEnabledCount;

	public T[] entries;

	private bool firstDeserialization;

	private int arrayLength;

	private void OnEnable()
	{
	}

	public virtual void Randomize()
	{
	}

	private List<SimulatedRandomEntry> RebuildVirtualPool(T[] pool)
	{
		return null;
	}

	public virtual void RandomizeWithCount(int count)
	{
	}

	public virtual void PerformTheAction(RandomEntry entry)
	{
	}

	private void OnValidate()
	{
	}
}
