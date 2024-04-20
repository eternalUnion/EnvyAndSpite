using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PortalRadius : MonoBehaviour
{
	public event Action<IPortalTraveller> travellerEntered
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<IPortalTraveller> travellerExited
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
