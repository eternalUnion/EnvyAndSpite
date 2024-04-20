using UnityEngine;
using UnityEngine.UI;

public class LevelSelectPanel : MonoBehaviour
{
	public float collapsedHeight;

	public float expandedHeight;

	public GameObject leaderboardPanel;

	private RectTransform rectTransform;

	public int levelNumber;

	public int levelNumberInLayer;

	private Text panelTitle;

	private bool allSecrets;

	public Sprite lockedSprite;

	public Sprite unlockedSprite;

	private Sprite origSprite;

	public Image[] secretIcons;

	public Image challengeIcon;

	private int tempInt;

	private string origName;

	private LayerSelect ls;

	private GameObject challengeChecker;

	private bool beenChecked;

	public bool forceOff;

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
