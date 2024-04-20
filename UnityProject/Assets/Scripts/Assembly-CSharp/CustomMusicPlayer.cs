using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

public class CustomMusicPlayer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CShowPanelRoutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CustomMusicPlayer _003C_003E4__this;

		public Playlist.SongMetadata song;

		private float _003Ctime_003E5__2;

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
		public _003CShowPanelRoutine_003Ed__14(int _003C_003E1__state)
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
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public List<AudioClip> clips;

		internal void _003CPlaylistRoutine_003Eb__1(AudioClip clip)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CPlaylistRoutine_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CustomMusicPlayer _003C_003E4__this;

		private _003C_003Ec__DisplayClass15_0 _003C_003E8__1;

		private WaitUntil _003CthemeNotPlaying_003E5__2;

		private Playlist.SongIdentifier _003ClastSong_003E5__3;

		private bool _003Cfirst_003E5__4;

		private IEnumerable<Playlist.SongIdentifier> _003CcurrentOrder_003E5__5;

		private IEnumerator<Playlist.SongIdentifier> _003C_003E7__wrap5;

		private Playlist.SongIdentifier _003Cid_003E5__7;

		private Playlist.SongMetadata _003CcurrentSongMetadata_003E5__8;

		private int _003Ci_003E5__9;

		private AsyncOperationHandle<SoundtrackSong> _003Cop_003E5__10;

		private List<AudioClip>.Enumerator _003C_003E7__wrap10;

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
		public _003CPlaylistRoutine_003Ed__15(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		private void _003C_003Em__Finally2()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private CanvasGroup panelGroup;

	[SerializeField]
	private Text panelText;

	[SerializeField]
	private Image panelIcon;

	[SerializeField]
	private MusicChanger changer;

	[SerializeField]
	private CustomMusicPlaylistEditor playlistEditor;

	[SerializeField]
	private Sprite defaultIcon;

	public float panelApproachTime;

	public float panelStayTime;

	private System.Random random;

	private bool stopped;

	public Dictionary<Playlist.SongIdentifier, (AudioClip, List<AudioClip>)> clipCache;

	public void OnEnable()
	{
	}

	public void StartPlaylist()
	{
	}

	public void StopPlaylist()
	{
	}

	[IteratorStateMachine(typeof(_003CShowPanelRoutine_003Ed__14))]
	private IEnumerator ShowPanelRoutine(Playlist.SongMetadata song)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlaylistRoutine_003Ed__15))]
	private IEnumerator PlaylistRoutine()
	{
		return null;
	}
}
