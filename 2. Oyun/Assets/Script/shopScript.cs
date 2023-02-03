using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shopScript : MonoBehaviour
{
    private int gemAmount;
    private int goldAmount;
    public Button product1;
    public Button product2;
    public Button product3;
    public Button product4;
    public Button product5;
    public Button product6;
    public Button product7;
    public Button product8;
    public Button product9;
    public Button product10;
    public Button product11;
    /// <summary>
    /// /////////////////////////////////////////
    /// </summary>
    public Button backProduct1;
    public Button backProduct2;
    public Button backProduct3;
    public Button backProduct4;
    public Button backProduct5;
    public Button backProduct6;
    public Button backProduct7;
   


    public Text goldText;
    public Text goldText2;
    public Text gemText;
   

    private void Start()
    {
        gemAmount = PlayerPrefs.GetInt("gemAmount");
        goldAmount = PlayerPrefs.GetInt("goldAmount");
        checkProducts();
        /*
        PlayerPrefs.DeleteKey("product1");
        PlayerPrefs.DeleteKey("product2");
        PlayerPrefs.DeleteKey("product3");
        PlayerPrefs.DeleteKey("product4");
        PlayerPrefs.DeleteKey("product5");
        PlayerPrefs.DeleteKey("product6");
        PlayerPrefs.DeleteKey("product7");
        PlayerPrefs.DeleteKey("product8");
        PlayerPrefs.DeleteKey("product9");
        PlayerPrefs.DeleteKey("product10");
        PlayerPrefs.DeleteKey("product11");
        
        PlayerPrefs.DeleteKey("backgroundP1");
        PlayerPrefs.DeleteKey("backgroundP2");
        PlayerPrefs.DeleteKey("backgroundP3");
        PlayerPrefs.DeleteKey("backgroundP4");
        PlayerPrefs.DeleteKey("backgroundP5");
        PlayerPrefs.DeleteKey("backgroundP6");
        PlayerPrefs.DeleteKey("backgroundP7");
        */
        //PlayerPrefs.DeleteAll();
    }
    public void checkProducts()
    {
        if (PlayerPrefs.GetInt("product1") == 1)
        {
            product1.gameObject.SetActive(false);
            
        }
        if (PlayerPrefs.GetInt("product2") == 1)
        {
            product2.gameObject.SetActive(false);
          
        }
        if (PlayerPrefs.GetInt("product3") == 1)
        {
            product3.gameObject.SetActive(false);
          
        }
        if (PlayerPrefs.GetInt("product4") == 1)
        {
            product4.gameObject.SetActive(false);
           
        }
        if (PlayerPrefs.GetInt("product5") == 1)
        {
            product5.gameObject.SetActive(false);
            
        }
        if (PlayerPrefs.GetInt("product6") == 1)
        {
            product6.gameObject.SetActive(false);
           
        }
        if (PlayerPrefs.GetInt("product7") == 1)
        {
            product7.gameObject.SetActive(false);
          
        }
        if (PlayerPrefs.GetInt("product8") == 1)
        {
            product8.gameObject.SetActive(false);
            
        }
        if (PlayerPrefs.GetInt("product9") == 1)
        {
            product9.gameObject.SetActive(false);
            
        }
        if (PlayerPrefs.GetInt("product10") == 1)
        {
            product10.gameObject.SetActive(false);
         
        }
        if (PlayerPrefs.GetInt("product11") == 1)
        {
            product11.gameObject.SetActive(false);
       
        }
        ///////////////////////////////////////////////////////////////////
        if (PlayerPrefs.GetInt("backgroundP1") == 1)
        {
            backProduct1.gameObject.SetActive(false);

        }
        if (PlayerPrefs.GetInt("backgroundP2") == 1)
        {
            backProduct2.gameObject.SetActive(false);

        }
        if (PlayerPrefs.GetInt("backgroundP3") == 1)
        {
            backProduct3.gameObject.SetActive(false);

        }
        if (PlayerPrefs.GetInt("backgroundP4") == 1)
        {
            backProduct4.gameObject.SetActive(false);

        }
        if (PlayerPrefs.GetInt("backgroundP5") == 1)
        {
            backProduct5.gameObject.SetActive(false);

        }
        if (PlayerPrefs.GetInt("backgroundP6") == 1)
        {
            backProduct6.gameObject.SetActive(false);

        }
        if (PlayerPrefs.GetInt("backgroundP7") == 1)
        {
            backProduct7.gameObject.SetActive(false);

        }
    }
    public void writeGoldAmount2()
    {
        goldAmount = PlayerPrefs.GetInt("goldAmount");

        goldText.GetComponent<Text>().text = goldAmount.ToString("");
        goldText2.GetComponent<Text>().text = goldAmount.ToString("");
    }
    public void P1minus250()
    {
        goldAmount = PlayerPrefs.GetInt("goldAmount");
        if (goldAmount > 250)
        {
            
            goldAmount = goldAmount - 250;
            PlayerPrefs.SetInt("goldAmount",goldAmount);
            PlayerPrefs.SetInt("product1",1);
            product1.gameObject.SetActive(false);
            writeGoldAmount2();
        }
        else if(goldAmount<250)
        {
            //NOT ENOUGH GOLD
        }
        else
        {
            //PURCHASE FAILED
        }
    }
    public void P2minus250()
    {
        goldAmount = PlayerPrefs.GetInt("goldAmount");
        if (goldAmount > 250)
        {
            goldAmount = goldAmount - 250;
            PlayerPrefs.SetInt("goldAmount",goldAmount);
            PlayerPrefs.SetInt("product2",1);
            product2.gameObject.SetActive(false);
            writeGoldAmount2();
        }
        else if (goldAmount < 250)
        {
            //NOT ENOUGH GOLD
        }
        else
        {
            //PURCHASE FAILED
        }
    }
    public void P3minus250()
    {
        goldAmount = PlayerPrefs.GetInt("goldAmount");
        if (goldAmount > 250)
        {
            goldAmount = goldAmount - 250;
            PlayerPrefs.SetInt("goldAmount",goldAmount);
            PlayerPrefs.SetInt("product3",1);
            product3.gameObject.SetActive(false);
            writeGoldAmount2();
        }
        else if (goldAmount < 250)
        {
            //NOT ENOUGH GOLD
        }
        else
        {
            //PURCHASE FAILED
        }
    }
   
    public void P4minus250()
    {
        goldAmount = PlayerPrefs.GetInt("goldAmount");
        if (goldAmount > 250)
        {
            goldAmount = goldAmount - 250;
            PlayerPrefs.SetInt("goldAmount",goldAmount);
            PlayerPrefs.SetInt("product4",1);
            product4.gameObject.SetActive(false);
            writeGoldAmount2();
        }
        else if (goldAmount < 250)
        {
            //NOT ENOUGH GOLD
        }
        else
        {
            //PURCHASE FAILED
        }
    }
    public void P5minus250()
    {
        goldAmount = PlayerPrefs.GetInt("goldAmount");
        if (goldAmount > 250)
        {
            goldAmount = goldAmount - 250;
            PlayerPrefs.SetInt("goldAmount",goldAmount);
            PlayerPrefs.SetInt("product5",1);
            product5.gameObject.SetActive(false);
            writeGoldAmount2();
        }
        else if (goldAmount < 250)
        {
            //NOT ENOUGH GOLD
        }
        else
        {
            //PURCHASE FAILED
        }
    }
    public void P6minus250()
    {
        goldAmount = PlayerPrefs.GetInt("goldAmount");
        if (goldAmount > 250)
        {
            goldAmount = goldAmount - 250;
            PlayerPrefs.SetInt("goldAmount",goldAmount);
            PlayerPrefs.SetInt("product6",1);
            product6.gameObject.SetActive(false);
            writeGoldAmount2();
        }
        else if (goldAmount < 250)
        {
            //NOT ENOUGH GOLD
        }
        else
        {
            //PURCHASE FAILED
        }
    }
    public void P7minus250()
    {
        goldAmount = PlayerPrefs.GetInt("goldAmount");
        if (goldAmount > 250)
        {
            goldAmount = goldAmount - 250;
            PlayerPrefs.SetInt("goldAmount",goldAmount);
            PlayerPrefs.SetInt("product7",1);
            product7.gameObject.SetActive(false);
            writeGoldAmount2();
        }
        else if (goldAmount < 250)
        {
            //NOT ENOUGH GOLD
        }
        else
        {
            //PURCHASE FAILED
        }
    }
    public void P8minus250()
    {
        goldAmount = PlayerPrefs.GetInt("goldAmount");
        if (goldAmount > 250)
        {
            goldAmount = goldAmount - 250;
            PlayerPrefs.SetInt("goldAmount",goldAmount);
            PlayerPrefs.SetInt("product8",1);
            product8.gameObject.SetActive(false);
            writeGoldAmount2();
        }
        else if (goldAmount < 250)
        {
            //NOT ENOUGH GOLD
        }
        else
        {
            //PURCHASE FAILED
        }
    }
    public void P9minus250()
    {
        goldAmount = PlayerPrefs.GetInt("goldAmount");
        if (goldAmount > 250)
        {
            goldAmount = goldAmount - 250;
            PlayerPrefs.SetInt("goldAmount",goldAmount);
            PlayerPrefs.SetInt("product9",1);
            product9.gameObject.SetActive(false);
            writeGoldAmount2();
        }
        else if (goldAmount < 250)
        {
            //NOT ENOUGH GOLD
        }
        else
        {
            //PURCHASE FAILED
        }
    }
    public void P10minus250()
    {
        goldAmount = PlayerPrefs.GetInt("goldAmount");
        if (goldAmount > 250)
        {
            goldAmount = goldAmount - 250;
            PlayerPrefs.SetInt("goldAmount",goldAmount);
            PlayerPrefs.SetInt("product10",1);
            product10.gameObject.SetActive(false);
            writeGoldAmount2();
        }
        else if (goldAmount < 250)
        {
            //NOT ENOUGH GOLD
        }
        else
        {
            //PURCHASE FAILED
        }
    }
    public void P11minus250()
    {
        goldAmount = PlayerPrefs.GetInt("goldAmount");
        if (goldAmount > 250)
        {
            goldAmount = goldAmount - 250;
            PlayerPrefs.SetInt("goldAmount",goldAmount);
            PlayerPrefs.SetInt("product11",1);
            product11.gameObject.SetActive(false);
            writeGoldAmount2();
        }
        else if (goldAmount < 250)
        {
            //NOT ENOUGH GOLD
        }
        else
        {
            //PURCHASE FAILED
        }
    }

    public void bP1()
    {
        goldAmount = PlayerPrefs.GetInt("goldAmount");
        if (goldAmount > 500)
        {
            goldAmount = goldAmount - 500;
            PlayerPrefs.SetInt("goldAmount", goldAmount);
            PlayerPrefs.SetInt("backgroundP1", 1);
            backProduct1.gameObject.SetActive(false);
            writeGoldAmount2();
        }
        else if (goldAmount < 500)
        {
            //NOT ENOUGH GOLD
        }
        else
        {
            //PURCHASE FAILED
        }
    }
    public void bP2()
    {
        goldAmount = PlayerPrefs.GetInt("goldAmount");
        if (goldAmount > 1000)
        {
            goldAmount = goldAmount - 1000;
            PlayerPrefs.SetInt("goldAmount", goldAmount);
            PlayerPrefs.SetInt("backgroundP2", 1);
            backProduct2.gameObject.SetActive(false);
            writeGoldAmount2();
        }
        else if (goldAmount < 1000)
        {
            //NOT ENOUGH GOLD
        }
        else
        {
            //PURCHASE FAILED
        }
    }
    public void bP3()
    {
        goldAmount = PlayerPrefs.GetInt("goldAmount");
        if (goldAmount > 1000)
        {
            goldAmount = goldAmount - 1000;
            PlayerPrefs.SetInt("goldAmount", goldAmount);
            PlayerPrefs.SetInt("backgroundP3", 1);
            backProduct3.gameObject.SetActive(false);
            writeGoldAmount2();
        }
        else if (goldAmount < 1000)
        {
            //NOT ENOUGH GOLD
        }
        else
        {
            //PURCHASE FAILED
        }
    }
    public void bP4()
    {
        goldAmount = PlayerPrefs.GetInt("goldAmount");
        if (goldAmount > 1000)
        {
            goldAmount = goldAmount - 1000;
            PlayerPrefs.SetInt("goldAmount", goldAmount);
            PlayerPrefs.SetInt("backgroundP4", 1);
            backProduct4.gameObject.SetActive(false);
            writeGoldAmount2();
        }
        else if (goldAmount < 1000)
        {
            //NOT ENOUGH GOLD
        }
        else
        {
            //PURCHASE FAILED
        }
    }
    public void bP5()
    {
        goldAmount = PlayerPrefs.GetInt("goldAmount");
        if (goldAmount > 1000)
        {
            goldAmount = goldAmount - 1000;
            PlayerPrefs.SetInt("goldAmount", goldAmount);
            PlayerPrefs.SetInt("backgroundP5", 1);
            backProduct5.gameObject.SetActive(false);
            writeGoldAmount2();
        }
        else if (goldAmount < 1000)
        {
            //NOT ENOUGH GOLD
        }
        else
        {
            //PURCHASE FAILED
        }
    }
    public void bP6()
    {
        goldAmount = PlayerPrefs.GetInt("goldAmount");
        if (goldAmount > 1000)
        {
            goldAmount = goldAmount - 1000;
            PlayerPrefs.SetInt("goldAmount", goldAmount);
            PlayerPrefs.SetInt("backgroundP6", 1);
            backProduct6.gameObject.SetActive(false);
            writeGoldAmount2();
        }
        else if (goldAmount < 1000)
        {
            //NOT ENOUGH GOLD
        }
        else
        {
            //PURCHASE FAILED
        }
    }
    public void bP7()
    {
        goldAmount = PlayerPrefs.GetInt("goldAmount");
        if (goldAmount > 1000)
        {
            goldAmount = goldAmount - 1000;
            PlayerPrefs.SetInt("goldAmount", goldAmount);
            PlayerPrefs.SetInt("backgroundP7", 1);
            backProduct7.gameObject.SetActive(false);
            writeGoldAmount2();
        }
        else if (goldAmount < 1000)
        {
            //NOT ENOUGH GOLD
        }
        else
        {
            //PURCHASE FAILED
        }
    }
}
