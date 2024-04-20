using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using plog.Models;

namespace plog
{
	public static class PConfig
	{
		public static bool PassToUnity
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static bool PassToCustomHandlers
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static bool CollectStackTraces
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static bool TagCallerMethodName
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static bool DisableAllLogs
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static List<Action<Log>> CustomLogHandlers
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static List<Action<IEnumerable<LogTag>>> TagListListeners
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static void AddLogHandler(Action<Log> handler)
		{
		}

		public static void RemoveLogHandler(Action<Log> handler)
		{
		}

		public static void AddTagListListener(Action<IEnumerable<LogTag>> listener)
		{
		}

		public static void RemoveTagListListener(Action<IEnumerable<LogTag>> listener)
		{
		}
	}
}
