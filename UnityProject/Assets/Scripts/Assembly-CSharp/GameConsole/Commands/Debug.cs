using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameConsole.CommandTree;

namespace GameConsole.Commands
{
	public class Debug : CommandRoot
	{
		[CompilerGenerated]
		private sealed class _003CBurstPrint_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Console console;

			public ConsoleLogType type;

			public int count;

			private int _003Ci_003E5__2;

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
			public _003CBurstPrint_003Ed__7(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CKillRespawnDelayed_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool wasPaused;

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
			public _003CKillRespawnDelayed_003Ed__8(int _003C_003E1__state)
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

		public static bool AgonyDebugOverlay;

		public override string Name => null;

		public override string Description => null;

		public Debug(Console con)
			: base(null)
		{
		}

		protected override Branch BuildTree(Console con)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CBurstPrint_003Ed__7))]
		private IEnumerator BurstPrint(Console console, int count, ConsoleLogType type)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CKillRespawnDelayed_003Ed__8))]
		private IEnumerator KillRespawnDelayed(bool wasPaused)
		{
			return null;
		}
	}
}
