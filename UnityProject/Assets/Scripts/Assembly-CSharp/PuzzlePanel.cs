using UnityEngine;
using UnityEngine.UI;

public class PuzzlePanel : MonoBehaviour
{
	[HideInInspector]
	public TileType tileType;

	[HideInInspector]
	public TileColor tileColor;

	[HideInInspector]
	public GameObject currentPanel;

	[HideInInspector]
	public GameObject whiteSquare;

	[HideInInspector]
	public GameObject blackSquare;

	[HideInInspector]
	public GameObject fillSquare;

	public GameObject pitSquare;

	private Image img;

	private bool activated;

	private PuzzleController pc;

	[HideInInspector]
	public PuzzleLine pl;

	private ControllerPointer pointer;

	private void Start()
	{
	}

	public void Activate(TileColor color)
	{
	}

	public void DeActivate()
	{
	}
}
