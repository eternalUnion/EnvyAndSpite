using UnityEngine;
using UnityEngine.Events;

public class Flammable : MonoBehaviour
{
	public float heat;

	private GameObject currentFire;

	private AudioSource currentFireAud;

	private Light currentFireLight;

	public bool burning;

	private bool fading;

	public bool secondary;

	private bool enemy;

	private EnemyIdentifierIdentifier eidid;

	private Flammable[] flammables;

	public bool wet;

	public bool playerOnly;

	public bool enemyOnly;

	public bool specialFlammable;

	public UnityEvent onSpecialActivate;

	private Collider col;

	private bool alwaysSimpleFire;

	private bool markedForDestroy;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private bool IsLossyScaleInvalid()
	{
		return false;
	}

	public void Burn(float newHeat, bool noInstaDamage = false)
	{
	}

	private void Pulse()
	{
	}

	public void PutOut(bool getWet = true)
	{
	}

	public void MarkForDestroy()
	{
	}

	public void ReturnToQueue()
	{
	}
}
