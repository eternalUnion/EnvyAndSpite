using System.Runtime.CompilerServices;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Camera))]
[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
public class CameraFrustumTargeter : MonoSingleton<CameraFrustumTargeter>
{
	private const int MaxPotentialTargets = 256;

	[SerializeField]
	private RectTransform crosshair;

	[SerializeField]
	private LayerMask mask;

	[SerializeField]
	private LayerMask occlusionMask;

	[SerializeField]
	private float maximumRange;

	public float maxHorAim;

	private RaycastHit[] occluders;

	private Plane[] frustum;

	private Vector3[] corners;

	private Bounds bounds;

	private Collider[] targets;

	private Camera camera;

	public Collider CurrentTarget
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsAutoAimed
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static bool IsEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected override void Awake()
	{
	}

	private bool RaycastFromViewportCenter(out RaycastHit hit)
	{
		hit = default(RaycastHit);
		return false;
	}

	private void CalculateFrustumInformation()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public CameraFrustumTargeter()
	{

	}
}
