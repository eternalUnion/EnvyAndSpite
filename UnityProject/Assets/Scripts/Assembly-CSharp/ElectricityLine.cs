using UnityEngine;

public class ElectricityLine : MonoBehaviour
{
	private LineRenderer lr;

	public Material[] lightningMats;

	public float minWidth;

	public float maxWidth;

	public Gradient colors;

	private float cooldown;

	public float fadeSpeed;

	private float fadeLerp;

	private void Update()
	{
	}
}
