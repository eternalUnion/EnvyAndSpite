namespace Sandbox
{
	public class SandboxEnemy : SandboxSpawnableInstance
	{
		public EnemyIdentifier enemyId;

		public EnemyRadianceConfig radiance;

		private bool lastSpeedBuffState;

		private bool lastDamageBuffState;

		private bool lastHealthBuffState;

		private bool lastKinematicState;

		public override void Awake()
		{
		}

		public void RestoreRadiance(EnemyRadianceConfig config)
		{
		}

		public void UpdateRadiance()
		{
		}

		private void OnEnable()
		{
		}

		public SavedEnemy SaveEnemy()
		{
			return null;
		}

		public override void Pause(bool freeze = true)
		{
		}

		public override void Resume()
		{
		}
	}
}
