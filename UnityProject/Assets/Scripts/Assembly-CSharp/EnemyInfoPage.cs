using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemyInfoPage : ListComponent<EnemyInfoPage>
{
	[SerializeField]
	private TMP_Text enemyPageTitle;

	[SerializeField]
	private TMP_Text enemyPageContent;

	[SerializeField]
	private Transform enemyPreviewWrapper;

	[Space]
	[SerializeField]
	private Transform enemyList;

	[SerializeField]
	private GameObject buttonTemplate;

	[SerializeField]
	private Image buttonTemplateBackground;

	[SerializeField]
	private Image buttonTemplateForeground;

	[SerializeField]
	private Sprite lockedSprite;

	[Space]
	[SerializeField]
	private SpawnableObjectsDatabase objects;

	private SpawnableObject currentSpawnable;

	private void Start()
	{
	}

	public void UpdateInfo()
	{
	}

	private void SwapLayers(Transform target, int layer)
	{
	}

	private void DisplayInfo(SpawnableObject source)
	{
	}

	public void DisplayInfo()
	{
	}

	public void UndisplayInfo()
	{
	}

	public EnemyInfoPage()
	{

	}
}
