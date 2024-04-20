using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

public sealed class RestrictedSerializationBinder : SerializationBinder
{
	public HashSet<Type> AllowedTypes
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public override Type BindToType(string assemblyName, string typeName)
	{
		return null;
	}
}
