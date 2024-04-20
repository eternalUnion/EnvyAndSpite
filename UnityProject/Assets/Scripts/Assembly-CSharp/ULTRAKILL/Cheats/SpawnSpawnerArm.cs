using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sandbox.Arm;
using UnityEngine;

namespace ULTRAKILL.Cheats
{
	public class SpawnSpawnerArm : ICheat
	{
		private bool active;

		private List<SandboxArm> createdArms;

		private Dictionary<SpawnableType, SandboxArm> spawnedArmMap;

		private SpawnableType[][] mainArmTypes;

		public static List<GameObject> armSlot => null;

		public string LongName => null;

		public string Identifier => null;

		public string ButtonEnabledOverride => null;

		public string ButtonDisabledOverride => null;

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

		public static bool AnyArmActive => false;

		public void Enable()
		{
		}

		private SandboxArm CreateArm(SpawnableType type)
		{
			return null;
		}

		public void SelectArm(SpawnableObject obj)
		{
		}

		public void Disable()
		{
		}

		public void Update()
		{
		}
	}
}
