using System;
using GameConsole.CommandTree;

namespace GameConsole.Commands
{
	public class MapVar : CommandRoot
	{
		public override string Name => null;

		public override string Description => null;

		public MapVar(Console con)
			: base(null)
		{
		}

		protected override Branch BuildTree(Console con)
		{
			return null;
		}

		public static string GetFriendlyTypeName(Type type)
		{
			return null;
		}
	}
}
