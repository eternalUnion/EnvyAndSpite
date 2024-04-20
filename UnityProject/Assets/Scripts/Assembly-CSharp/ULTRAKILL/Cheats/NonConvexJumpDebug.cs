using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NewBlood.Rendering;
using UnityEngine;

namespace ULTRAKILL.Cheats
{
	public class NonConvexJumpDebug : ICheat
	{
		private static NonConvexJumpDebug _lastInstance;

		private bool active;

		private List<GameObject> _debugObjects;

		public static bool Active => false;

		public string LongName => null;

		public string Identifier => null;

		public string ButtonEnabledOverride
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string ButtonDisabledOverride
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string Icon => null;

		public bool IsActive => false;

		public bool DefaultState
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public StatePersistenceMode PersistenceMode => default(StatePersistenceMode);

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		public void Update()
		{
		}

		public static void Reset()
		{
		}

		public static void CreateBall(Color color, Vector3 position, float size = 1f)
		{
		}

		public static void CreateTri(Plane plane, Triangle<Vector3> triangle, Color color)
		{
		}
	}
}
