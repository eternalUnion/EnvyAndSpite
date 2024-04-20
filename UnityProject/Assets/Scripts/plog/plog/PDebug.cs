using System.Collections.Generic;
using System.Text.RegularExpressions;
using plog.Models;

namespace plog
{
	public static class PDebug
	{
		private static readonly Regex _alphaNumericRegex;

		private static readonly PCache _cache;

		public static void ProcessTags(IEnumerable<LogTag> tags)
		{
		}

		public static void RequestTagListUpdate()
		{
		}

		public static void PLog(string message, params LogTag[] tags)
		{
		}

		public static void PLog(string message, IEnumerable<LogTag> tags = null, string overrideStackTrace = null)
		{
		}

		public static void PWarning(string message, params LogTag[] tags)
		{
		}

		public static void PWarning(string message, IEnumerable<LogTag> tags = null, string overrideStackTrace = null)
		{
		}

		public static void PError(string message, params LogTag[] tags)
		{
		}

		public static void PError(string message, IEnumerable<LogTag> tags = null, string overrideStackTrace = null)
		{
		}

		public static void PLog(string message, PLogLevel level, IEnumerable<LogTag> tags = null, string overrideStackTrace = null)
		{
		}
	}
}
