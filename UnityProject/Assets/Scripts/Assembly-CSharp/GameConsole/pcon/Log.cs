using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using UnityEngine;
using pcon.core.Interfaces;
using plog.Models;

namespace GameConsole.pcon
{
	public class Log : ISend
	{
		private const string Type = "pcon.log";

		public string message;

		public string stacktrace;

		[JsonConverter(typeof(StringEnumConverter), new object[] { typeof(CamelCaseNamingStrategy) })]
		public PConLogLevel level;

		public long timestamp;

		public IEnumerable<int> tags;

		public int hash;

		public string type => null;

		private void ComputeHash()
		{
		}

		public Log(string message, IEnumerable<LogTag> tags = null)
		{
		}

		public Log(string message, string stacktrace, IEnumerable<LogTag> tags = null)
		{
		}

		public Log(string message, string stacktrace, LogType type, IEnumerable<LogTag> tags = null)
		{
		}

		public Log(string message, string stacktrace, PConLogLevel level, IEnumerable<LogTag> tags = null)
		{
		}
	}
}
