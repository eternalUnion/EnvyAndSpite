using System.Runtime.CompilerServices;
using UnityEngine;

namespace ULTRAKILL.Cheats
{
	public class Noclip : ICheat
	{
		private bool active;

		private Rigidbody rigidbody;

		private KeepInBounds kib;

		private Transform transform;

		private Transform camera;

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

		public void Enable()
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
