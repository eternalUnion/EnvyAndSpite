using System.Collections.Generic;
using UnityEngine;

public class WallCheck : MonoBehaviour
{
	public bool onWall;

	public Vector3 poc;

	public List<Collider> cols;

	private List<Collider> colsToDelete;

	private List<Collider> enemyCols;

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	public bool CheckForCols()
	{
		return false;
	}

	public bool CheckForEnemyCols()
	{
		return false;
	}
}
