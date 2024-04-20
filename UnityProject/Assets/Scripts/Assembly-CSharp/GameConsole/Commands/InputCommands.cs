using GameConsole.CommandTree;

namespace GameConsole.Commands
{
	internal class InputCommands : CommandRoot
	{
		public override string Name => null;

		public override string Description => null;

		public InputCommands(Console con)
			: base(null)
		{
		}

		protected override Branch BuildTree(Console con)
		{
			return null;
		}
	}
}
