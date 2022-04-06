using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    public int [,] shopItems = new int [4,4];
    public float coins;
    [HideInInspector] public Text coinsText;
    [HideInInspector] public Text damageText;

    [SerializeField] Player player;

    private void Start()
    {
        //coinsText.text = "Coins" + coins.ToString();

        //ID
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;

        //Price
        shopItems[2, 1] = 10;
        shopItems[2, 2] = 20;
        shopItems[2, 3] = 30;

        //Damage
        shopItems[3, 1] = 10;
        shopItems[3, 2] = 10;
        shopItems[3, 3] = 10;
    }
    public void Buy()

    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (player._coin >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            player._coin -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]+=10;
            coinsText.text= "Coins:" + coins.ToString();
            ButtonRef.GetComponent<ButtonInfo>().damageText.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
        }
    }
}
