using Sandbox;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
public class SandboxNavmesh : MonoSingleton<SandboxNavmesh>
{
	[SerializeField]
	private NavMeshSurface surface;

	public bool isDirty;

	public UnityAction navmeshBuilt;

	private Vector3 defaultCenter;

	private Vector3 defaultSize;

	protected override void Awake()
	{
	}

	public void MarkAsDirty(SandboxSpawnableInstance instance)
	{
	}

	public void Rebake()
	{
	}

	private void OnDrawGizmos()
	{
	}

	public void ResetSizeToDefault()
	{
	}

	public void EnsurePositionWithinBounds(Vector3 worldPosition)
	{
	}

	public SandboxNavmesh()
	{

	}
}
