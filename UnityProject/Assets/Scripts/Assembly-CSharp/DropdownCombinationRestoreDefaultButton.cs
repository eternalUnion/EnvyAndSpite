using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DropdownCombinationRestoreDefaultButton : MonoBehaviour
{
	[Serializable]
	public struct CombinationOption
	{
		public List<BooleanPrefOption> subOptions;
	}

	[Serializable]
	public struct BooleanPrefOption
	{
		public string prefKey;

		public bool isLocal;

		public bool expectedValue;
	}

	[SerializeField]
	private GameObject buttonContainer;

	public int defaultCombination;

	public List<CombinationOption> combinations;

	[SerializeField]
	private TMP_Dropdown dropdown;

	private bool isValueDirty;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void RestoreDefault()
	{
	}

	private void UpdateSelf()
	{
	}

	private void LateUpdate()
	{
	}
}
