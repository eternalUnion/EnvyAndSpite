namespace ULTRAKILL.Cheats.UnityEditor
{
	public class OverwriteUnlocks : ICheat
	{
		private static OverwriteUnlocks _lastInstance;

		private bool active;

		public static bool Enabled => false;

		public string LongName => null;

		public string Identifier => null;

		public string ButtonEnabledOverride => null;

		public string ButtonDisabledOverride => null;

		public string Icon => null;

		public bool IsActive => false;

		public bool DefaultState => false;

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
