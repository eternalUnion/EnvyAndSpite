using System;
using UnityEngine;

namespace GameConsole
{
	[Serializable]
	public class CapturedLog
	{
		public DateTime time;

		public string message;

		public string stackTrace;

		public ConsoleLogType type;

		public TimeSince timeSinceLogged;

		public bool expanded;

		public CapturedLog(string message, string stackTrace, ConsoleLogType type)
		{
		}

		public static ConsoleLogType LogToConLog(LogType type)
		{
			return default(ConsoleLogType);
		}

		public CapturedLog(string message, string stackTrace, LogType type)
		{
		}
	}
}
