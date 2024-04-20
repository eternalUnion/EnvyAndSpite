using System.Collections.Generic;
using UnityEngine;

public class SubtitleController : MonoSingleton<SubtitleController>
{
	public class SubtitleData
	{
		public string caption;

		public float time;

		public GameObject origin;
	}

	public bool subtitlesEnabled;

	[SerializeField]
	private Transform container;

	[SerializeField]
	private Subtitle subtitleLine;

	private Subtitle previousSubtitle;

	private List<SubtitleData> delayedSubs;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void NotifyHoldEnd(Subtitle self)
	{
	}

	public void DisplaySubtitleTranslated(string translationKey)
	{
	}

	public void DisplaySubtitle(string caption, AudioSource audioSource = null)
	{
	}

	public void DisplaySubtitle(string caption, float time, GameObject origin)
	{
	}

	public void CancelSubtitle(GameObject origin)
	{
	}

	public SubtitleController()
	{

	}
}
