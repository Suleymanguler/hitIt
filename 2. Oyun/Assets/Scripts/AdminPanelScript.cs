using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdminPanelScript : MonoBehaviour
{
    
    spawnerScript  spawnerscriptvar;
    scoreScript scoresriptvar;
    public GameObject adminPanel;
    public Text throwSpeedText;
    public Text rotateSpeedText;

    ///////////////////////////////////////////

    private int gold;
    private int gem;
    private void Start()
    {
        spawnerscriptvar = FindObjectOfType<spawnerScript>();
        scoresriptvar = FindObjectOfType<scoreScript>();
        


        gold = PlayerPrefs.GetInt("goldAmount");
        gem = PlayerPrefs.GetInt("gemAmount");
    }
    public void increaseSpeed()
    {
        spawnerscriptvar.throwSpeed += 50000;
        throwSpeedText.GetComponent<Text>().text = spawnerscriptvar.throwSpeed.ToString("");
    }
    
    public void decreaseSpeed()
    {
        spawnerscriptvar.throwSpeed -= 50000;
        throwSpeedText.GetComponent<Text>().text = spawnerscriptvar.throwSpeed.ToString("");
    }

    public void increaseRotation()
    {
        spawnerscriptvar.speed += 25;
        rotateSpeedText.GetComponent<Text>().text = spawnerscriptvar.speed.ToString("");
    }

    public void decreaseRotation()
    {
        spawnerscriptvar.speed -= 25;
        rotateSpeedText.GetComponent<Text>().text = spawnerscriptvar.speed.ToString("");
    }

    public void addGold()
    {
        gold = gold + 100;
        PlayerPrefs.SetInt("goldAmount", gold);
        scoresriptvar.writeGoldAmount();
    }
    public void substractGold()
    {
        gold = gold - 100;
        PlayerPrefs.SetInt("goldAmount", gold);
        scoresriptvar.writeGoldAmount();
        
    }

    public void addGem()
    {
        gem = gem + 20;
        PlayerPrefs.SetInt("gemAmount", gem);
        scoresriptvar.writeGemAmount();
    }
    
    public void substractGem()
    {
        gem = gem - 20;
        PlayerPrefs.SetInt("gemAmount", gem);
        scoresriptvar.writeGemAmount();
    }
    
    public void closePanel()
    {
        adminPanel.SetActive(false);
    }
    public void openPanel()
    {
        adminPanel.SetActive(true);
    }
}
