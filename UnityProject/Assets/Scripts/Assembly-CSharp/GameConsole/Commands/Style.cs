using GameConsole.CommandTree;

namespace GameConsole.Commands
{
	internal class Style : CommandRoot
	{
		public override string Name => null;

		public override string Description => null;

		public Style(Console con)
			: base(null)
		{
		}

		protected override Branch BuildTree(Console con)
		{
			return null;
		}
	}
}
