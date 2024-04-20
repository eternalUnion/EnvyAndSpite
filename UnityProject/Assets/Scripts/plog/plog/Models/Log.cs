using System.Collections.Generic;

namespace plog.Models
{
	public struct Log
	{
		public string message;

		public string stackTrace;

		public IEnumerable<LogTag> tags;

		public PLogLevel level;
	}
}
