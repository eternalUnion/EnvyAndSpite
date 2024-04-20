using System.Runtime.CompilerServices;

namespace ULTRAKILL.Cheats
{
	public class PlayerParentingDebug : ICheat, ICheatGUI
	{
		private static PlayerParentingDebug _lastInstance;

		private bool active;

		private PlayerMovementParenting[] pmp;

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

		public void OnGUI()
		{
		}
	}
}
