using System.Runtime.CompilerServices;

namespace ULTRAKILL.Cheats
{
	public class TeleportMenu : ICheat
	{
		public string LongName => null;

		public string Identifier => null;

		public string ButtonEnabledOverride => null;

		public string ButtonDisabledOverride => null;

		public string Icon => null;

		public bool IsActive
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

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
