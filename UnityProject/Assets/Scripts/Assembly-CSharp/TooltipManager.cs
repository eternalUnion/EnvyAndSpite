using System;
using System.Collections.Generic;
using UnityEngine;

public class TooltipManager : MonoBehaviour
{
	public GameObject tooltipTemplate;

	private Dictionary<Guid, GameObject> dict;

	public Guid ShowTooltip(Vector2 position, string text = "")
	{
		return default(Guid);
	}

	public void HideTooltip(Guid id)
	{
	}
}
