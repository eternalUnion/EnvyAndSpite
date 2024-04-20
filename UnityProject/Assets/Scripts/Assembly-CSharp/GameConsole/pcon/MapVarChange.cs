using pcon.core.Attributes;
using pcon.core.Interfaces;
using plog.Models;

namespace GameConsole.pcon
{
	[RegisterIncomingMessage("ultrakill.mapvar.update")]
	public class MapVarChange : IReceive
	{
		private static LogTag LogTag;

		private const string Type = "ultrakill.mapvar.update";

		public MapVarField variable;

		public string type => null;

		public void Receive()
		{
		}
	}
}
