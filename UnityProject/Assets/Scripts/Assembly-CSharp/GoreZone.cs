using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GoreZone : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDestroyNextFrame_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GoreZone _003C_003E4__this;

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
		public _003CDestroyNextFrame_003Ed__16(int _003C_003E1__state)
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

	[Header("Optional")]
	public Transform goreZone;

	public Transform gibZone;

	[HideInInspector]
	public CheckPoint checkpoint;

	[HideInInspector]
	public float maxGore;

	[HideInInspector]
	public List<GameObject> outsideGore;

	private bool endlessMode;

	private int maxGibs;

	public float goreRenderDistance;

	private bool goreUnrendered;

	public List<GameObject> toDestroy;

	private static GoreZone _globalRootAutomaticGz;

	private BloodsplatterManager bsm;

	public static GoreZone ResolveGoreZone(Transform transform)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void SlowUpdate()
	{
	}

	[IteratorStateMachine(typeof(_003CDestroyNextFrame_003Ed__16))]
	private IEnumerator DestroyNextFrame()
	{
		return null;
	}

	public void SetGoreZone(GameObject gib)
	{
	}

	private void Update()
	{
	}

	private void CheckRenderDistance()
	{
	}

	public void Combine()
	{
	}

	public void AddDeath()
	{
	}

	public void AddKillHitterTarget(int id)
	{
	}

	public void ResetBlood()
	{
	}

	public void ResetGibs()
	{
	}
}
