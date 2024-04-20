using GameConsole.CommandTree;

namespace GameConsole.Commands
{
	internal class Buffs : CommandRoot
	{
		public override string Name => null;

		public override string Description => null;

		public Buffs(Console con)
			: base(null)
		{
		}

		protected override Branch BuildTree(Console con)
		{
			return null;
		}
	}
}
