using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{
    public int ItemID;
    public Text priceText;
    public Text damageText;
    public GameObject ShopManager;

    private void Start()
    {
        priceText.text = "Price: $" + ShopManager.GetComponent<StoreManager>().shopItems[2, ItemID].ToString();
        damageText.text = "Price: $" + ShopManager.GetComponent<StoreManager>().shopItems[3, ItemID].ToString();
    }
}