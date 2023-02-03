using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelControlScript : MonoBehaviour
{
    public GameObject shopPanel;
    public GameObject arrowScroll;
    public GameObject backgroundScroll;
    public Text goldText2;
    public int goldAmount;
    shopScript ShopScript;

    public void BuyMenu()
    {
        shopPanel.SetActive(true);
        goldAmount = PlayerPrefs.GetInt("goldAmount");
        goldText2.GetComponent<Text>().text = goldAmount.ToString("");
        //ShopScript.checkProducts();

    }
    public void CloseBuyMenu()
    {
        shopPanel.SetActive(false);
    }
    public void ActiveArrowSkinScroll()
    {
        arrowScroll.SetActive(true);
        backgroundScroll.SetActive(false);
    }
    public void ActiveBackgroundScroll()
    {
        arrowScroll.SetActive(false);
        backgroundScroll.SetActive(true);
    }
    
}
