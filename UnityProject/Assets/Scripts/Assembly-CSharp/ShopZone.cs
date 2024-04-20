using UnityEngine;

public class ShopZone : ScreenZone
{
	private bool inUse;

	private Canvas shopCanvas;

	public bool firstVariationBuy;

	private ShopMother shom;

	private ShopCategory[] shopcats;

	public bool muteMusic;

	private float originalMusicVolume;

	private float musicTarget;

	private bool fading;

	public bool forcedOff;

	private void Start()
	{
	}

	protected override void Update()
	{
	}

	public void TurnOn()
	{
	}

	public void TurnOff()
	{
	}

	public void ForceOff()
	{
	}

	public void StopForceOff()
	{
	}
}
