using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
//using Vertx.Debugging;

namespace Train
{
	public class TrainTrackPoint : MonoBehaviour
	{
		[HideInInspector]
		public int instanceId;

		public List<TrainTrackPoint> forwardPoints = new List<TrainTrackPoint>();

		public List<TrainTrackPoint> backwardPoints = new List<TrainTrackPoint>();

		public StopBehaviour stopBehaviour;

		[HideInInspector]
		public int forwardPath;

		[HideInInspector]
		public int backwardPath;

		[HideInInspector]
		public TrackCurveSettings forwardCurveSettings;

		private static readonly Color ForwardActive = Color.green;

		private static readonly Color BackwardActive = new Color(0.4f, 0.6f, 0.5f);

		public TrainTrackPoint GetDestination(bool forward = true)
		{
			TrainTrackPoint trainTrackPoint;
			if (forward)
			{
				if (this.forwardPoints != null && this.forwardPoints.Count != 0)
				{
					if (!this.forwardPoints.All((TrainTrackPoint point) => point == null))
					{
						trainTrackPoint = this.forwardPoints[this.forwardPath];
						goto IL_AF;
					}
				}
				return null;
			}
			if (this.backwardPoints != null && this.backwardPoints.Count != 0)
			{
				if (!this.backwardPoints.All((TrainTrackPoint point) => point == null))
				{
					trainTrackPoint = this.backwardPoints[this.backwardPath];
					goto IL_AF;
				}
			}
			return null;
		IL_AF:
			if (trainTrackPoint == null || !trainTrackPoint.gameObject.activeSelf)
			{
				return null;
			}
			return trainTrackPoint;
		}

		private void OnDrawGizmos()
		{
			Vector3 position = base.transform.position;
			DrawPaths(forwardPoints, forwardPath, false);
			DrawPaths(backwardPoints, backwardPath, true);

			// D.raw(new Shape.Text(transform.position, name), Color.white);
		}

		private void Update()
		{
		}

		private void DrawPaths(IReadOnlyList<TrainTrackPoint> points, int path, bool backward)
		{
			Vector3 position = base.transform.position;
			if (points == null)
			{
				return;
			}
			for (int i = 0; i < points.Count; i++)
			{
				TrainTrackPoint trainTrackPoint = points[i];
				if (!(trainTrackPoint == null))
				{
					Vector3 position2 = trainTrackPoint.transform.position;
					bool flag = !trainTrackPoint.gameObject.activeSelf;
					if (path != i || flag)
					{
						Color red = Color.red;
					}
					else if (!backward)
					{
						Color forwardActive = TrainTrackPoint.ForwardActive;
					}
					else
					{
						Color backwardActive = TrainTrackPoint.BackwardActive;
					}
					TrackCurveSettings trackCurveSettings = backward ? trainTrackPoint.forwardCurveSettings : this.forwardCurveSettings;
					if (trackCurveSettings.curve == PathInterpolation.Linear)
					{
						Vector3 b = Vector3.Lerp(position, position2, flag ? 1f : 0.5f);
						// D.raw(new Shape.Line(position, b), ForwardActive);
						Debug.DrawLine(position, b, ForwardActive);
					}
					else if (trackCurveSettings.curve != PathInterpolation.SphericalManual/* && trackCurveSettings.handle == null*/)
					{
						int num = 16;
						TrainTrackPoint startPoint = backward ? trainTrackPoint : this;
						TrainTrackPoint endPoint = backward ? this : trainTrackPoint;
						Vector3 prevPoint = backward ? endPoint.transform.position : startPoint.transform.position;
						for (int j = 0; j <= num; j++)
						{
							float num2 = (float)j / (float)num;
							if (!flag)
							{
								num2 *= 0.5f;
							}
							if (backward)
							{
								num2 = 1f - num2;
							}

							Vector3 point = TramPath.GetPointOnSimulatedPath(num2, startPoint, endPoint);
							// D.raw(new Shape.Line(prevPoint, point), ForwardActive);
							Debug.DrawLine(prevPoint, point, ForwardActive);
							prevPoint = point;
						}
					}
					else if (trackCurveSettings.curve == PathInterpolation.SphericalManual && trackCurveSettings.handle != null)
					{
						int num = 16;
						TrainTrackPoint startPoint = backward ? trainTrackPoint : this;
						TrainTrackPoint endPoint = backward ? this : trainTrackPoint;
						Vector3 prevPoint = backward ? endPoint.transform.position : startPoint.transform.position;

						// D.raw(new Shape.Line(startPoint.transform.position, trackCurveSettings.handle.position), Color.white);
						Debug.DrawLine(startPoint.transform.position, trackCurveSettings.handle.position, Color.white);
						// D.raw(new Shape.Line(endPoint.transform.position, trackCurveSettings.handle.position), Color.white);
						Debug.DrawLine(endPoint.transform.position, trackCurveSettings.handle.position, Color.white);
						//if (!backward)
						//	Gizmos.DrawIcon(trackCurveSettings.handle.position, "tram_handle.png", false);
						for (int j = 0; j <= num; j++)
						{
							float num2 = (float)j / (float)num;
							if (!flag)
							{
								num2 *= 0.5f;
							}
							if (backward)
							{
								num2 = 1f - num2;
							}

							Vector3 point = PathTools.InterpolateAlongCircle(startPoint.transform.position, endPoint.transform.position, trackCurveSettings.handle.position, num2);
							// D.raw(new Shape.Line(prevPoint, point), ForwardActive);
							Debug.DrawLine(prevPoint, point, ForwardActive);
							prevPoint = point;
						}
					}
				}
			}
		}
	}
}
