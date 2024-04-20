using System.Collections.Generic;
using UnityEngine;
using plog.Models;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
public class BossBarManager : MonoSingleton<BossBarManager>
{
	public static readonly LogTag Tag;

	[SerializeField]
	private float overflowShrinkFactor;

	[SerializeField]
	private float minimumSize;

	[SerializeField]
	private float baseOverflowedSize;

	[Space]
	[SerializeField]
	private RectTransform containerRect;

	[SerializeField]
	private BossHealthBarTemplate template;

	[SerializeField]
	private SliderLayer[] layers;

	private readonly Dictionary<int, BossHealthBarTemplate> bossBars;

	private readonly Dictionary<int, TimeSince> bossBarLastUpdated;

	private readonly Queue<int> bossBarsToRemove;

	private const float BossBarTimeToExpire = 3f;

	public void UpdateBossBar(BossHealthBar bossBar)
	{
	}

	public void ExpireImmediately(int bossBarId)
	{
	}

	private void CreateBossBar(BossHealthBar bossBar)
	{
	}

	private void Update()
	{
	}

	private void RecalculateStretch()
	{
	}

	public BossBarManager()
	{

	}
}
