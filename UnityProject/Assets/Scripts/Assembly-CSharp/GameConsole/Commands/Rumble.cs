using GameConsole.CommandTree;

namespace GameConsole.Commands
{
	public class Rumble : CommandRoot
	{
		public override string Name => null;

		public override string Description => null;

		public Rumble(Console con)
			: base(null)
		{
		}

		protected override Branch BuildTree(Console con)
		{
			return null;
		}
	}
}
