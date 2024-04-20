using System.Collections.Generic;
using UnityEngine;

public class ScrollingTexture : MonoBehaviour
{
	private static MaterialPropertyBlock _propertyBlock;

	public float scrollSpeedX;

	public float scrollSpeedY;

	private Dictionary<int, int[]> texturePropertyStNames;

	private Material[] sharedMaterials;

	private MeshRenderer mr;

	private Vector2 offset;

	public bool scrollAttachedObjects;

	public Vector3 force;

	public bool relativeDirection;

	public List<Transform> attachedObjects;

	[HideInInspector]
	public Bounds bounds;

	[HideInInspector]
	public bool valuesSet;

	[HideInInspector]
	public List<GameObject> cleanUp;

	[HideInInspector]
	public List<WaterDryTracker> specialScrollers;

	[HideInInspector]
	public List<Rigidbody> touchingRbs;

	private void Start()
	{
	}

	private void SlowUpdate()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}
}
