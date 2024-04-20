using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

[BaseTypeRequired(typeof(MonoSingleton<>))]
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public sealed class ConfigureSingletonAttribute : Attribute
{
	public SingletonFlags Flags
	{
		[CompilerGenerated]
		get
		{
			return default(SingletonFlags);
		}
	}

	public ConfigureSingletonAttribute(SingletonFlags flags)
	{
	}
}
