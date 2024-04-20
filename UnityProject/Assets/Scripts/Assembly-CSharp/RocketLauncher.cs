using UnityEngine;
using UnityEngine.UI;

public class RocketLauncher : MonoBehaviour
{
	public int variation;

	public GameObject rocket;

	public GameObject clunkSound;

	public float rateOfFire;

	private float cooldown;

	private bool lookingForValue;

	private AudioSource aud;

	private Animator anim;

	private WeaponIdentifier wid;

	public Transform shootPoint;

	public GameObject muzzleFlash;

	[SerializeField]
	private Image timerMeter;

	[SerializeField]
	private RectTransform timerArm;

	[SerializeField]
	private Image[] variationColorables;

	private float[] colorablesTransparencies;

	[Header("Freeze variation")]
	[SerializeField]
	private AudioSource timerFreezeSound;

	[SerializeField]
	private AudioSource timerUnfreezeSound;

	[SerializeField]
	private AudioSource timerTickSound;

	[HideInInspector]
	public AudioSource currentTimerTickSound;

	[SerializeField]
	private AudioSource timerWindupSound;

	private float lastKnownTimerAmount;

	[Header("Cannonball variation")]
	public Rigidbody cannonBall;

	[SerializeField]
	private AudioSource chargeSound;

	private float cbCharge;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void Shoot()
	{
	}

	public void ShootCannonball()
	{
	}

	public void FreezeRockets()
	{
	}

	public void UnfreezeRockets()
	{
	}

	public void Clunk(float pitch)
	{
	}
}
