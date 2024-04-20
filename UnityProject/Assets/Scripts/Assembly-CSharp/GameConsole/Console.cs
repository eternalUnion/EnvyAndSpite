using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using plog.Models;

namespace GameConsole
{
	[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
	public class Console : MonoSingleton<Console>
	{
		[Serializable]
		public class AutocompletePanel
		{
			public Text text;

			public Image background;
		}

		[CompilerGenerated]
		private sealed class _003CFadeBlockerIn_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Console _003C_003E4__this;

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
			public _003CFadeBlockerIn_003Ed__67(int _003C_003E1__state)
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

		public bool pinned;

		public bool consoleOpen;

		public List<CapturedLog> logs;

		public ConsoleLogType filters;

		public int errorCount;

		public int warningCount;

		public int infoCount;

		private readonly List<LogLine> logLinePool;

		[SerializeField]
		private GameObject consoleContainer;

		[SerializeField]
		private CanvasGroup consoleBlocker;

		[SerializeField]
		private InputField consoleInput;

		[Space]
		[SerializeField]
		private LogLine logLine;

		[SerializeField]
		private GameObject logContainer;

		[Space]
		[SerializeField]
		private GameObject scroller;

		[SerializeField]
		private Text scrollText;

		[SerializeField]
		private Text openBindText;

		[SerializeField]
		private AutocompletePanel[] autocompletePanels;

		[Space]
		public ErrorBadge errorBadge;

		[Space]
		[SerializeField]
		private GameObject[] hideOnPin;

		[SerializeField]
		private GameObject[] hideOnPinNoReopen;

		[SerializeField]
		private Image[] backgrounds;

		[SerializeField]
		private CanvasGroup masterGroup;

		[Space]
		public ConsoleWindow consoleWindow;

		private const int MaxLogLines = 20;

		private bool openedDuringPause;

		private OptionsManager rememberedOptionsManager;

		public readonly Dictionary<string, ICommand> recognizedCommands;

		public readonly HashSet<Type> registeredCommandTypes;

		private int scrollState;

		private UnscaledTimeSince timeSincePgHeld;

		private UnscaledTimeSince timeSinceScrollTick;

		private List<string> commandHistory;

		private int commandHistoryIndex;

		public Action onError;

		public Binds binds;

		private List<string> suggestions;

		private int selectedSuggestionIndex;

		private int suggestionStartIndex;

		private PconAdapter pconAdapter;

		private static LogTag consoleTag => null;

		public static bool IsOpen => false;

		private List<CapturedLog> filteredLogs => null;

		protected override void Awake()
		{
		}

		public void StartPCon()
		{
		}

		public void UpdateDisplayString()
		{
		}

		public bool CheatBlocker()
		{
			return false;
		}

		public void RegisterCommands(IEnumerable<ICommand> commands)
		{
		}

		public void RegisterCommand(ICommand command)
		{
		}

		public void PrintLine(string text)
		{
		}

		public void Clear()
		{
		}

		private void IncrementCounters(ConsoleLogType type)
		{
		}

		public void PrintLine(string text, ConsoleLogType type, string stackTrace = "")
		{
		}

		public void UpdateFilters(bool showErrors, bool showWarnings, bool showLogs)
		{
		}

		public string[] Parse(string text)
		{
			return null;
		}

		private void ProcessUserInput(string text)
		{
		}

		public void ProcessInput(string text)
		{
		}

		private void ScrollUp()
		{
		}

		private void ScrollDown()
		{
		}

		private void DefaultDevConsoleOff()
		{
		}

		private void OnGUI()
		{
		}

		private void LateUpdate()
		{
		}

		private void Update()
		{
		}

		private void UpdateScroller()
		{
		}

		[IteratorStateMachine(typeof(_003CFadeBlockerIn_003Ed__67))]
		private IEnumerator FadeBlockerIn()
		{
			return null;
		}

		private void SelectSuggestion(int newIndex, bool wrap = false)
		{
		}

		private void ShowSuggestions(int selected)
		{
		}

		private void FindSuggestions(string value)
		{
		}

		private void OnDisable()
		{
		}

		private void InsertLog(CapturedLog log)
		{
		}

		private void RepopulateLogs()
		{
		}

		private void HandleLog(string message, string stacktrace, LogType type)
		{
		}

		public Console()
		{

		}
	}
}
