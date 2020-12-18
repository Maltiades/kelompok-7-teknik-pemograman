using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{
    public int ItemID;
    public Text PriceTXT;
    public Text QuantityTXT;
    public Text QuantityTXTINV; 
    public GameObject ShopManager;
    

    void Start()
    {
        QuantityTXT.text = QuantityTXT.text;
        QuantityTXTINV.text = QuantityTXTINV.text;
    }


    void update()
    {
        PriceTXT.text = ShopManager.GetComponent<ShopManagerScript>().shopItems[2, ItemID].ToString();
        QuantityTXT.text = ShopManager.GetComponent<ShopManagerScript>().shopItems[3, ItemID].ToString();
    }
}
