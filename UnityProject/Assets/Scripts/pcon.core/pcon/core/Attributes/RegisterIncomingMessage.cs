using System;
using System.Runtime.CompilerServices;

namespace pcon.core.Attributes
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public class RegisterIncomingMessage : Attribute
	{
		public string type
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public RegisterIncomingMessage(string type)
		{
		}
	}
}
