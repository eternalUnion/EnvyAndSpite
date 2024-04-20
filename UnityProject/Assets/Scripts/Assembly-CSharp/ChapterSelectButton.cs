using UnityEngine;
using UnityEngine.UI;

public class ChapterSelectButton : MonoBehaviour
{
	public LayerSelect[] layersInChapter;

	public Text rankText;

	private Image buttonBg;

	public int totalScore;

	public bool notComplete;

	public int golds;

	public int allPerfects;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void CheckScore()
	{
	}
}
