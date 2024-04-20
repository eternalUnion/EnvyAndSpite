using UnityEngine;
using UnityEngine.UI;

public class LayerSelect : MonoBehaviour
{
	public SecretMissionPanel secretMissionPanel;

	public int layerNumber;

	public int levelAmount;

	private float totalScore;

	private float scoresChecked;

	private int perfects;

	public int golds;

	private bool secretMission;

	public Text rankText;

	public bool gold;

	public bool allPerfects;

	public int trueScore;

	public bool complete;

	public bool noSecretMission;

	[HideInInspector]
	public LevelSelectLeaderboard[] childLeaderboards;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	public void CheckScore()
	{
	}

	public void AddScore(int score, bool perfect = false)
	{
	}

	public void Gold()
	{
	}

	public void SecretMissionDone()
	{
	}
}
