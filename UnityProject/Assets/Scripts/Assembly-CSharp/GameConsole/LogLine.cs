using UnityEngine;
using UnityEngine.UI;

namespace GameConsole
{
	public class LogLine : MonoBehaviour
	{
		[SerializeField]
		private Text timestamp;

		[SerializeField]
		private Text message;

		[SerializeField]
		private Image mainPanel;

		[Space]
		[SerializeField]
		private CanvasGroup attentionFlashGroup;

		[Space]
		[SerializeField]
		private Color normalLogColor;

		[SerializeField]
		private Color warningLogColor;

		[SerializeField]
		private Color errorLogColor;

		[SerializeField]
		private Color cliLogColor;

		[Space]
		[SerializeField]
		private float normalHeight;

		[SerializeField]
		private float expandedHeight;

		private RectTransform rectTransform;

		private CapturedLog log;

		private void Awake()
		{
		}

		public void Wipe()
		{
		}

		public void PopulateLine(CapturedLog log)
		{
		}

		public void ToggleExpand()
		{
		}

		private void RefreshSize()
		{
		}

		private void Update()
		{
		}

		private float TimeSinceToFlashAlpha(float timeSinceLogged)
		{
			return 0f;
		}
	}
}
