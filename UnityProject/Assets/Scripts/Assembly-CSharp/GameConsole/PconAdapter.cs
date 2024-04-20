using System;
using System.Reflection;
using plog.Models;

namespace GameConsole
{
	public class PconAdapter
	{
		private static readonly LogTag OwnTag;

		private Assembly pconAssmebly;

		private Type pconClientType;

		private bool startCalled;

		public bool PConLibraryExists()
		{
			return false;
		}

		public void StartPConClient(Action<string> onExecute, Action onGameModified)
		{
		}
	}
}
