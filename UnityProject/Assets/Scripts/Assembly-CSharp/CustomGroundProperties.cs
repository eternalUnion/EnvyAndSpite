using UnityEngine;

public class CustomGroundProperties : MonoBehaviour
{
	public float friction;

	public float speedMultiplier;

	public bool push;

	public Vector3 pushForce;

	public bool pushDirectionRelative;

	public bool canJump;

	public bool silentJumpFail;

	public float jumpForceMultiplier;

	public bool canSlide;

	public bool silentSlideFail;

	public bool canDash;

	public bool silentDashFail;

	public bool launchable;

	public bool forceCrouch;

	public bool overrideFootsteps;

	public AudioClip newFootstepSound;

	public bool dontRotateCamera;
}
