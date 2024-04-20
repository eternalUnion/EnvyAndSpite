using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Train
{
	public class Tram : MonoBehaviour
	{
		public bool canGoForward { get; private set; }

		public bool canGoBackward { get; private set; }

		public TramMovementDirection movementDirection
		{
			get
			{
				if (speed > 0f)
				{
					return TramMovementDirection.Forward;
				}
				if (speed >= 0f)
				{
					return TramMovementDirection.None;
				}
				return TramMovementDirection.Backward;
			}
		}

		public float directionMod
		{
			get
			{
				return (float)((speed > 0f) ? 1 : -1);
			}
		}

		public float computedSpeed
		{
			get
			{
				return speed * inheritedSpeedMultiplier;
			}
		}

		public float inheritedSpeedMultiplier
		{
			get
			{
				TramPath tramPath = currentPath;
				if (tramPath == null)
				{
					return 1f;
				}
				return tramPath.MaxSpeedMultiplier(movementDirection, speed);
			}
		}

		public float backwardOffset
		{
			get
			{
				if (connectedTrams != null && connectedTrams.Length != 0)
				{
					return connectedTrams.Sum((ConnectedTram tram) => tram.offset);
				}
				return 0f;
			}
		}

		public void TurnOn()
		{
			poweredOn = true;
			if (screenActivators != null && screenActivators.Length != 0)
			{
				ScreenZone[] array = screenActivators;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].gameObject.SetActive(true);
				}
			}
		}

		public void ShutDown()
		{
			poweredOn = false;
			if (screenActivators != null && screenActivators.Length != 0)
			{
				foreach (ScreenZone screenZone in screenActivators)
				{
					ObjectActivator[] components = screenZone.GetComponents<ObjectActivator>();
					if (components != null && components.Length != 0)
					{
						foreach (ObjectActivator objectActivator in components)
						{
							if (objectActivator.events.toActivateObjects != null && objectActivator.events.toActivateObjects.Length != 0)
							{
								GameObject[] toActivateObjects = objectActivator.events.toActivateObjects;
								for (int k = 0; k < toActivateObjects.Length; k++)
								{
									toActivateObjects[k].SetActive(false);
								}
							}
						}
					}
					screenZone.gameObject.SetActive(false);
				}
			}
		}

		public void StopAndTeleport(TrainTrackPoint point)
		{
			currentPoint = point;
			currentPath = null;
			speed = 0f;
			TrainTrackPoint destination = currentPoint.GetDestination(true);
			TrainTrackPoint destination2 = currentPoint.GetDestination(false);
			TramPath tramPath = null;
			if (destination)
			{
				tramPath = new TramPath(currentPoint, destination);
			}
			else if (destination2)
			{
				tramPath = new TramPath(destination2, currentPoint);
				tramPath.distanceTravelled = tramPath.DistanceTotal;
			}
			if (tramPath != null)
			{
				currentPath = tramPath;
				UpdateWorldRotation();
				ConnectedTram[] array = connectedTrams;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].UpdateTram(currentPath);
				}
				currentPath = null;
			}
		}

		private void Awake()
		{
			aud = GetComponent<AudioSource>();
			screenActivators = GetComponentsInChildren<ScreenZone>();
		}

		private void Update()
		{
			UpdateAudio();
		}

		private void FixedUpdate()
		{
			if (currentPath == null && currentPoint != null)
			{
				transform.position = currentPoint.transform.position;
				canGoForward = (currentPoint.GetDestination(true) != null);
				canGoBackward = (currentPoint.GetDestination(false) != null);
			}
			if (speed != 0f)
			{
				if (currentPath == null && currentPoint != null)
				{
					ReceiveNewPath();
				}
				if (currentPath != null)
				{
					TraversePath();
				}
			}
			if (currentPath != null)
			{
				UpdateWorldPosition();
				if (movementDirection != TramMovementDirection.None)
				{
					UpdateWorldRotation();
				}
				DrawPathPreview();
				ConnectedTram[] array = connectedTrams;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].UpdateTram(currentPath);
				}
			}
		}

		private void DrawPathPreview()
		{
			if (!Debug.isDebugBuild)
			{
				return;
			}
			int num = 16;
			Vector3 a = transform.position;
			for (int i = 0; i < num; i++)
			{
				float progress = currentPath.Progress + (float)i / (float)num * directionMod;
				Vector3 pointOnPath = currentPath.GetPointOnPath(progress);
				Vector3 vector = Vector3.up * 1f;
				// new Shape.Line(a + vector, pointOnPath + vector);
				Debug.DrawLine(a + vector, pointOnPath + vector, Color.blue);
				Vector3 b = vector + new Vector3(0f, 0.125f, 0f);
				// new Shape.Line(a + b, pointOnPath + b);
				Debug.DrawLine(a + b, pointOnPath + b, Color.blue);
				a = pointOnPath;
			}
		}

		private void TraversePath()
		{
			currentPath.distanceTravelled += computedSpeed * Time.deltaTime;
			if (!IsAtEndOfPath())
			{
				canGoForward = true;
				canGoBackward = true;
				return;
			}
			float num = currentPath.distanceTravelled;
			if (movementDirection == TramMovementDirection.Forward)
			{
				num -= currentPath.DistanceTotal;
			}
			if (movementDirection == TramMovementDirection.Backward && backwardOffset != 0f && currentPath.IsDeadEnd(movementDirection))
			{
				speed = 0f;
				canGoBackward = false;
				Object.Instantiate<GameObject>(bonkSound, transform.position, Quaternion.identity);
				return;
			}
			currentPoint = ((movementDirection == TramMovementDirection.Forward) ? currentPath.end : currentPath.start);
			if (currentPoint != null)
			{
				Debug.Log("Reached " + currentPoint.gameObject.name);
			}
			currentPath = null;
			ReceiveNewPath();
			if (currentPath == null)
			{
				if (currentPoint.stopBehaviour == StopBehaviour.InstantClank)
				{
					Object.Instantiate<GameObject>(bonkSound, transform.position, Quaternion.identity);
				}
				if (movementDirection == TramMovementDirection.Forward)
				{
					canGoForward = false;
				}
				else
				{
					canGoBackward = false;
				}
				speed = 0f;
				return;
			}
			Debug.Log("New path: " + currentPath.PrintPathDirectional(movementDirection));
			currentPath.distanceTravelled += num;
			if (movementDirection == TramMovementDirection.Forward)
			{
				canGoForward = true;
				return;
			}
			canGoBackward = true;
		}

		private bool IsAtEndOfPath()
		{
			if (currentPath == null)
			{
				return false;
			}
			float distanceTotal = currentPath.DistanceTotal;
			float num = 0f;
			if (movementDirection == TramMovementDirection.Backward && backwardOffset != 0f && currentPath.start.GetDestination(false) == null)
			{
				num += backwardOffset;
			}
			if (movementDirection != TramMovementDirection.Forward)
			{
				return currentPath.distanceTravelled <= num;
			}
			return currentPath.distanceTravelled >= distanceTotal;
		}

		public void UpdateWorldPosition()
		{
			if (currentPath == null)
			{
				return;
			}
			Vector3 pointOnPath = currentPath.GetPointOnPath(currentPath.Progress);
			transform.position = pointOnPath;
		}

		public void UpdateWorldRotation()
		{
			if (currentPath == null)
			{
				return;
			}
			Quaternion rotation = Quaternion.LookRotation(currentPath.MovementDirection(), Vector3.up);
			transform.rotation = rotation;
		}

		private void ReceiveNewPath()
		{
			if (currentPoint == null)
			{
				return;
			}
			bool flag = movementDirection == TramMovementDirection.Forward;
			TrainTrackPoint destination = currentPoint.GetDestination(flag);
			if (destination == null)
			{
				return;
			}
			TrainTrackPoint start = flag ? currentPoint : destination;
			TrainTrackPoint end = flag ? destination : currentPoint;
			TramPath tramPath = new TramPath(start, end);
			if (!flag)
			{
				tramPath.distanceTravelled = tramPath.DistanceTotal;
			}
			currentPath = tramPath;
			currentPoint = null;
		}

		private void UpdateAudio()
		{
			if (computedSpeed != 0f && !aud.isPlaying)
			{
				aud.Play();
			}
			else if (computedSpeed == 0f && aud.isPlaying)
			{
				aud.Stop();
			}
			float num;
			if (Mathf.Abs(computedSpeed) >= 50f)
			{
				num = 1f;
			}
			else
			{
				num = Mathf.Abs(computedSpeed) * 0.02f;
			}
			aud.volume = num;
			aud.pitch = num * 2f;
		}

		public bool poweredOn = true;

		private AudioSource aud;

		public GameObject bonkSound;

		public float speed;

		public ConnectedTram[] connectedTrams;

		[Space]
		public TrainTrackPoint currentPoint;

		public TramPath currentPath;

		private ScreenZone[] screenActivators;
	}
}
