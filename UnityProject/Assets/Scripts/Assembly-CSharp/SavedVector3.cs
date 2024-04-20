using System;
using UnityEngine;

[Serializable]
public class SavedVector3
{
	public float x;

	public float y;

	public float z;

	public SavedVector3(Vector3 vector3)
	{
	}

	public Vector3 ToVector3()
	{
		return default(Vector3);
	}
}
