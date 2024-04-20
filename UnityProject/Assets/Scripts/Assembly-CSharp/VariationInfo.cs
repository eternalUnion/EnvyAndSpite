using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VariationInfo : MonoBehaviour
{
	public GameObject varPage;

	private int money;

	public int cost;

	public TMP_Text costText;

	public ShopButton buyButton;

	private TMP_Text buttonText;

	public GameObject buySound;

	public Button equipButton;

	private Image equipImage;

	public Sprite[] equipSprites;

	private int equipStatus;

	public bool alreadyOwned;

	public string weaponName;

	private GunSetter gs;

	private FistControl fc;

	private GameObject player;

	public GameObject orderButtons;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	public void UpdateMoney()
	{
	}

	public void WeaponBought()
	{
	}

	public void ChangeEquipment(int value)
	{
	}
}
