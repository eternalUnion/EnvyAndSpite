using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

[ConfigureSingleton(SingletonFlags.NoAutoInstance | SingletonFlags.PersistAutoInstance | SingletonFlags.DestroyDuplicates)]
public class SceneHelper : MonoSingleton<SceneHelper>
{
	[CompilerGenerated]
	private sealed class _003CLoadSceneAsync_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string sceneName;

		public SceneHelper _003C_003E4__this;

		public bool noSplash;

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
		public _003CLoadSceneAsync_003Ed__39(int _003C_003E1__state)
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

	[SerializeField]
	private AssetReference finalRoomPit;

	[SerializeField]
	private GameObject loadingBlocker;

	[SerializeField]
	private TMP_Text loadingBar;

	[SerializeField]
	private GameObject preloadingBadge;

	[SerializeField]
	private GameObject eventSystem;

	[Space]
	[SerializeField]
	private AudioMixerGroup masterMixer;

	[SerializeField]
	private AudioMixerGroup musicMixer;

	[SerializeField]
	private AudioMixer allSound;

	[SerializeField]
	private AudioMixer goreSound;

	[SerializeField]
	private AudioMixer musicSound;

	[SerializeField]
	private AudioMixer doorSound;

	[SerializeField]
	private AudioMixer unfreezeableSound;

	[Space]
	[SerializeField]
	private EmbeddedSceneInfo embeddedSceneInfo;

	public static bool IsPlayingCustom => false;

	public static bool IsSceneRankless => false;

	public static int CurrentLevelNumber => 0;

	public static string CurrentScene
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static string LastScene
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static string PendingScene
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	protected override void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public bool IsSceneSpecial(string sceneName)
	{
		return false;
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	public static string SanitizeLevelPath(string scene)
	{
		return null;
	}

	public static void ShowLoadingBlocker()
	{
	}

	public static void DismissBlockers()
	{
	}

	public static void LoadScene(string sceneName, bool noBlocker = false)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadSceneAsync_003Ed__39))]
	private IEnumerator LoadSceneAsync(string sceneName, bool noSplash = false)
	{
		return null;
	}

	public static void RestartScene()
	{
	}

	public static void LoadPreviousScene()
	{
	}

	public static void SpawnFinalPitAndFinish()
	{
	}

	public static void SetLoadingSubtext(string text)
	{
	}

	public int? GetLevelIndexAfterIntermission(string intermissionScene)
	{
		return null;
	}

	public SceneHelper()
	{

	}
}
