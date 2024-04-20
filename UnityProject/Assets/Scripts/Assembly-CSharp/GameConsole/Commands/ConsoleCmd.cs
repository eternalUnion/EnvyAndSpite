using GameConsole.CommandTree;

namespace GameConsole.Commands
{
	public class ConsoleCmd : CommandRoot
	{
		public override string Name => null;

		public override string Description => null;

		public ConsoleCmd(Console con)
			: base(null)
		{
		}

		protected override Branch BuildTree(Console con)
		{
			return null;
		}

		private void ListDefaults(Console con)
		{
		}
	}
}
