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

    private void Update()
    {
        priceText.text = "Price: " + ShopManager.GetComponent<StoreManager>().shopItems[2, ItemID].ToString();
        damageText.text = "Damage" + ShopManager.GetComponent<StoreManager>().shopItems[3, ItemID].ToString();
        ShopManager.GetComponent<StoreManager>().coinsText.text = "Coins:" + Player.instance._coin.ToString();
    }
    public void Buy()
    {
        if (Player.instance._coin >= ShopManager.GetComponent<StoreManager>().shopItems[2, ItemID])
        {
            Player.instance._coin -= ShopManager.GetComponent<StoreManager>().shopItems[2, ItemID];
            Player.instance.danage += ShopManager.GetComponent<StoreManager>().shopItems[3, ItemID];
            ShopManager.GetComponent<StoreManager>().shopItems[2, ItemID] += 10;
            ShopManager.GetComponent<StoreManager>().shopItems[3, ItemID] += 10;
        }
    }
}
