using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EZCameraShake;


public class scoreScript : MonoBehaviour
{
    public Text scoreBoard;
    public int score=0;
    public int scoreCheck;
    Timer timerScriptVar2;
    spawnerScript funcCaller;
    public GameObject redPanel;
    public Text goldText;
    
    public Text gemText;
    public int goldAmount;
    public int gemAmount;
    FlameControl funcCallerFlame;

    public GameObject comboTextx2;
    public GameObject comboTextx3;

    public int flag = 0;

    spawnerScript rotateSpeed;
    int speedR;
    

    void Start()
    {
        rotateSpeed = FindObjectOfType<spawnerScript>();
        speedR = rotateSpeed.speedVar;
        goldAmount = PlayerPrefs.GetInt("goldAmount");
        PlayerPrefs.SetInt("goldAmount", goldAmount);
        gemAmount = PlayerPrefs.GetInt("gemAmount");
        scoreCheck = 0;
        PlayerPrefs.SetInt("scoreControl", 0);
        timerScriptVar2 = FindObjectOfType<Timer>();
        funcCaller = FindObjectOfType<spawnerScript>();
        funcCallerFlame = FindObjectOfType<FlameControl>();
        redPanel.SetActive(false);
        writeGoldAmount();
        writeGemAmount();
    }

    public void writeGoldAmount()
    {
        goldAmount = PlayerPrefs.GetInt("goldAmount");
        goldText.GetComponent<Text>().text = goldAmount.ToString("");
        

    }

    public void writeGemAmount()
    {
        gemAmount = PlayerPrefs.GetInt("gemAmount");
        gemText.GetComponent<Text>().text = gemAmount.ToString("");
    }
   
    
  
    public void writeScore()
    {
        if (timerScriptVar2.comboCounter > 2 && timerScriptVar2.comboCounter<5)
        {
            rotateSpeed.speed = 170;
            goldAmount = PlayerPrefs.GetInt("goldAmount");
            comboTextx2.SetActive(true);
            flag = 0;
            redPanel.SetActive(true);
            score +=20;
            CameraShaker.Instance.ShakeOnce(0.5f, 8f, 0.5f, 0.5f);
            funcCaller.twentyPointsFloating();
            funcCaller.plusTwo();
            redPanel.SetActive(false);
            goldAmount += 2;
            PlayerPrefs.SetInt("goldAmount", goldAmount);
        }
        else if (timerScriptVar2.comboCounter >= 5)
        {
            rotateSpeed.speed = 200;
            goldAmount = PlayerPrefs.GetInt("goldAmount");
            comboTextx2.SetActive(false);
            comboTextx3.SetActive(true);
            flag = 1;
            score +=30;
            funcCaller.plusThree();
            funcCaller.thirtyPointsFloating();
            CameraShaker.Instance.ShakeOnce(2f, 8f, 0.5f, 0.5f);
            goldAmount += 3;
            PlayerPrefs.SetInt("goldAmount", goldAmount);
        }
        else if(timerScriptVar2.comboCounter<=2)
        {
            rotateSpeed.speed = 130;
            goldAmount = PlayerPrefs.GetInt("goldAmount");
            comboTextx2.SetActive(false);
            comboTextx3.SetActive(false);
            flag = 0;
            score +=10;
            funcCaller.plusOne();
            funcCaller.tenPointsFloating();
            goldAmount += 1;
            PlayerPrefs.SetInt("goldAmount", goldAmount);
        }
        PlayerPrefs.SetInt("scoreControl", score);
        scoreBoard.GetComponent<Text>().text = score.ToString("");
        

    }
    
}
