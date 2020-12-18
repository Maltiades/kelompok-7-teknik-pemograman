using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManagerScript : MonoBehaviour
{

    public int[,] shopItems = new int[5,5];
    public int coins;
    public Text CoinsTXT;
    public Text CoinsTXTShop;
    
    [SerializeField] Animator NoEatAnim;
    [SerializeField] Text OwnedText;
    [SerializeField] Animator NoCoinsAnim;
    [SerializeField] Text CoinsText;
    [SerializeField] Animator EatBreadAnim;
    [SerializeField] Text BreadAnim;
    [SerializeField] Animator EatCherryAnim;
    [SerializeField] Text CherryAnim;
    [SerializeField] Animator EatBananaAnim;
    [SerializeField] Text BananaAnim;



    void Start()
    {
        CoinsTXT.text = coins.ToString();
        CoinsTXTShop.text = coins.ToString();

        //ID's
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;

        //Price
        shopItems[2, 1] = 10;
        shopItems[2, 2] = 20;
        shopItems[2, 3] = 30;
        shopItems[2, 4] = 10;

        //Quantity
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;
        shopItems[3, 3] = 0;
        shopItems[3, 4] = 0;

        
    }

   
    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (coins >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            coins -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]++;
            CoinsTXT.text = coins.ToString();
            CoinsTXTShop.text = coins.ToString();
            ButtonRef.GetComponent<ButtonInfo>().QuantityTXT.text = "Owned : " + shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
            ButtonRef.GetComponent<ButtonInfo>().QuantityTXTINV.text = "Owned : " + shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
        }

        else 
        {
            NoCoinsAnim.SetTrigger ("NoCoins");
        }      
    }

    public void AddCredits()
    {
        /*GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        coins += shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
        
        */

        coins += 10;
        Debug.Log(coins);
        CoinsTXT.text = coins.ToString();
        CoinsTXTShop.text = coins.ToString();
    }

    public void EatBread()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if(shopItems[3, 1] >= 1)
        {
            shopItems[3, 1] -= 1;
            ButtonRef.GetComponent<ButtonInfo>().QuantityTXT.text = "Owned : " + shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
            ButtonRef.GetComponent<ButtonInfo>().QuantityTXTINV.text = "Owned : " + shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
            EatBreadAnim.SetTrigger ("EatBread");
        }
        else 
        {
            NoEatAnim.SetTrigger ("NoEat");
        }      
        
    }

    public void EatCherry()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if(shopItems[3, 2] >= 1)
        {
            shopItems[3, 2] -= 1;
            ButtonRef.GetComponent<ButtonInfo>().QuantityTXT.text = "Owned : " + shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
            ButtonRef.GetComponent<ButtonInfo>().QuantityTXTINV.text = "Owned : " + shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
            EatCherryAnim.SetTrigger ("EatCherry");
        }
        else 
        {
            NoEatAnim.SetTrigger ("NoEat");
        }      
        
    }

    public void EatBanana()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if(shopItems[3, 3] >= 1)
        {
            shopItems[3, 3] -= 1;
            ButtonRef.GetComponent<ButtonInfo>().QuantityTXT.text = "Owned : " + shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
            ButtonRef.GetComponent<ButtonInfo>().QuantityTXTINV.text = "Owned : " + shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
            EatBananaAnim.SetTrigger ("EatBanana");
        }
        else 
        {
            NoEatAnim.SetTrigger ("NoEat");
        }      
        
    }
}