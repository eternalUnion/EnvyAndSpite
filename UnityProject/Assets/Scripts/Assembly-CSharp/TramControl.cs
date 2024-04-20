using Train;
using UnityEngine;
using UnityEngine.UI;

public class TramControl : MonoBehaviour
{
	public void SpeedUp()
	{
		if (SpeedUp(1))
		{
			if (clickSound)
			{
				Object.Instantiate<GameObject>(clickSound, transform.position, Quaternion.identity);
				return;
			}
		}
		else if (clickFailSound)
		{
			Object.Instantiate<GameObject>(clickFailSound, transform.position, Quaternion.identity);
		}
	}

	public void SpeedDown()
	{
		if (SpeedDown(1))
		{
			if (clickSound)
			{
				Object.Instantiate<GameObject>(clickSound, transform.position, Quaternion.identity);
				return;
			}
		}
		else if (clickFailSound)
		{
			Object.Instantiate<GameObject>(clickFailSound, transform.position, Quaternion.identity);
		}
	}

	public bool SpeedUp(int amount)
	{
		if (!targetTram.poweredOn)
		{
			return false;
		}
		if (targetTram.currentPoint != null && targetTram.currentPoint.GetDestination(true) == null)
		{
			return false;
		}
		if (currentSpeedStep < maxSpeedStep)
		{
			if (currentSpeedStep + amount <= maxSpeedStep)
			{
				currentSpeedStep += amount;
			}
			else
			{
				currentSpeedStep = maxSpeedStep;
			}
			return true;
		}
		return false;
	}

	public bool SpeedDown(int amount)
	{
		if (!targetTram.poweredOn)
		{
			return false;
		}
		if (targetTram.currentPoint != null && targetTram.currentPoint.GetDestination(false) == null)
		{
			return false;
		}
		if (currentSpeedStep > minSpeedStep)
		{
			if (currentSpeedStep - amount >= minSpeedStep)
			{
				currentSpeedStep -= amount;
			}
			else
			{
				currentSpeedStep = minSpeedStep;
			}
			return true;
		}
		return false;
	}

	private void LateUpdate()
	{
		targetTram.speed = Mathf.MoveTowards(targetTram.speed, (float)currentSpeedStep * (speedMultiplier / 10f), speedMultiplier / 10f * Time.fixedDeltaTime);
		if (currentSpeedStep != 0)
		{
			if (!targetTram.poweredOn)
			{
				currentSpeedStep = 0;
			}
			else if (targetTram.movementDirection == TramMovementDirection.Forward && !targetTram.canGoForward)
			{
				currentSpeedStep = 0;
				targetTram.speed = 0f;
			}
			else if (targetTram.movementDirection == TramMovementDirection.Backward && !targetTram.canGoBackward)
			{
				currentSpeedStep = 0;
				targetTram.speed = 0f;
			}
		}
		if (lastSpeedStep != currentSpeedStep)
		{
			lastSpeedStep = currentSpeedStep;
			UpdateSpeedIndicators();
		}
	}

	private void FixedUpdate()
	{
		/*if (maxPlayerDistance != 0f && Vector3.Distance(transform.position, MonoSingleton<PlayerTracker>.Instance.GetPlayer().position) > maxPlayerDistance)
		{
			currentSpeedStep = 0;
		}*/
	}

	private void UpdateSpeedIndicators()
	{
		for (int i = 0; i < speedIndicators.Length; i++)
		{
			speedIndicators[i].fillCenter = (i == currentSpeedStep - minSpeedStep);
		}
	}

	[SerializeField]
	private Tram targetTram;

	[Space]
	[SerializeField]
	private GameObject clickSound;

	[SerializeField]
	private GameObject clickFailSound;

	[Space]
	[SerializeField]
	private int maxSpeedStep;

	[SerializeField]
	private int minSpeedStep;

	[SerializeField]
	private float speedMultiplier;

	[SerializeField]
	private Image[] speedIndicators;

	public float maxPlayerDistance = 15f;

	public int currentSpeedStep;

	private int lastSpeedStep;
}
