using System.Collections.Generic;
using plog.Models;

namespace plog
{
	public class PCache
	{
		private List<LogTag> _tagList;

		private HashSet<LogTag> _tagSet;

		private Dictionary<string, LogTag> _tagLookup;

		public void AddTag(LogTag tag)
		{
		}

		public IEnumerable<LogTag> GetTags()
		{
			return null;
		}

		public void UpdateListeners()
		{
		}

		public LogTag GetOrCreateTag(string name)
		{
			return null;
		}
	}
}
