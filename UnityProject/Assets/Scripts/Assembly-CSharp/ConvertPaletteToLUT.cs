using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[ConfigureSingleton(SingletonFlags.PersistAutoInstance)]
public class ConvertPaletteToLUT : MonoSingleton<ConvertPaletteToLUT>
{
	[CompilerGenerated]
	private sealed class _003CpaletteToLUT_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Material conversionMaterial;

		public ConvertPaletteToLUT _003C_003E4__this;

		private int _003Cprogress_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CpaletteToLUT_003Ed__6(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public RenderTexture processedLUT;

	public RenderTexture lastLUT;

	public Texture2D lastPalette;

	private IEnumerator coroutine;

	public void ApplyLastPalette()
	{
	}

	public void ConvertPalette(Texture2D inputPalette, Material conversionMaterial)
	{
	}

	[IteratorStateMachine(typeof(_003CpaletteToLUT_003Ed__6))]
	private IEnumerator paletteToLUT(Material conversionMaterial)
	{
		return null;
	}

	public ConvertPaletteToLUT()
	{

	}
}
