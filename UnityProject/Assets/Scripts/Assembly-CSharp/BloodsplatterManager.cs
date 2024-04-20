using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
public class BloodsplatterManager : MonoSingleton<BloodsplatterManager>
{
	[CompilerGenerated]
	private sealed class _003CInitPools_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BloodsplatterManager _003C_003E4__this;

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
		public _003CInitPools_003Ed__23(int _003C_003E1__state)
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

	public GameObject head;

	public GameObject limb;

	public GameObject body;

	public GameObject small;

	public GameObject smallest;

	public GameObject splatter;

	public GameObject underwater;

	public GameObject sand;

	public GameObject blessing;

	public GameObject chestExplosion;

	public GameObject brainChunk;

	public GameObject skullChunk;

	public GameObject eyeball;

	public GameObject jawChunk;

	public GameObject[] gib;

	private Dictionary<BSType, Queue<GameObject>> gorePool;

	private Dictionary<BSType, int> defaultHPValues;

	private int order;

	private Transform goreStore;

	public bool hasBloodFillers;

	public HashSet<GameObject> bloodFillers;

	private WaitForSeconds slowUpdate;

	private void Start()
	{
	}

	private GameObject GetPrefabByBSType(BSType bloodType)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CInitPools_003Ed__23))]
	private IEnumerator InitPools()
	{
		return null;
	}

	private void InitPool(BSType bloodSplatterType)
	{
	}

	public void RepoolGore(Bloodsplatter bs, BSType type)
	{
	}

	public void RepoolGore(GameObject go, BSType type)
	{
	}

	private void ReturnToQueue(GameObject go, BSType type)
	{
	}

	public GameObject GetFromQueue(BSType type)
	{
		return null;
	}

	public GameObject GetGore(GoreType got, EnemyIdentifier eid)
	{
		return null;
	}

	public GameObject GetGore(GoreType got, bool isUnderwater = false, bool isSandified = false, bool isBlessed = false, EnemyIdentifier eid = null)
	{
		return null;
	}

	public GameObject GetGib(BSType type)
	{
		return null;
	}

	private AudioSource GetOriginalAudio(GoreType got)
	{
		return null;
	}

	private float GetSplatterWeight(GoreType got)
	{
		return 0f;
	}

	public BloodsplatterManager()
	{

	}
}
