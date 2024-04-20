using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ControlsOptions : MonoBehaviour
{
	private InputManager inman;

	[HideInInspector]
	public OptionsManager opm;

	public Transform actionParent;

	public GameObject actionTemplate;

	public GameObject sectionTemplate;

	public Toggle scrollWheel;

	public TMP_Dropdown variationWheel;

	public Toggle reverseWheel;

	private GameObject currentKey;

	public Color normalColor;

	public Color pressedColor;

	private bool canUnpause;

	public Selectable selectableAboveRebinds;

	private List<GameObject> rebindUIObjects;

	public GameObject modalBackground;

	public void ShowModal()
	{
	}

	public void HideModal()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnActionChanged(InputAction action)
	{
	}

	public void ResetToDefault()
	{
	}

	private void Rebuild(InputControlScheme controlScheme)
	{
	}

	private void LateUpdate()
	{
	}

	public void ScrollOn(bool stuff)
	{
	}

	public void ScrollVariations(int stuff)
	{
	}

	public void ScrollReverse(bool stuff)
	{
	}
}
