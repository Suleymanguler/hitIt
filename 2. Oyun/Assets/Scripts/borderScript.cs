using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class borderScript : MonoBehaviour
{
    public GameObject losePanel;
    public int highscoreVar=0;
    public int scoreControlVar;
    public Text highScoreText;
    public Text highScoreText2;
    public Text congratsText;
    public Text scoreText;
    public GameObject pauseGameButton;
   
    void Start()
    {
      
        losePanel.SetActive(false);
        highscoreVar = PlayerPrefs.GetInt("highScore");
       //highScoreText.GetComponent<Text>().text = "High score:"+highscoreVar.ToString("");
        highScoreText2.GetComponent<Text>().text = "High score:" + highscoreVar.ToString("");
        congratsText.gameObject.SetActive(false);
        scoreControlVar = 0;

    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        pauseGameButton.SetActive(false);
        scoreControlVar = PlayerPrefs.GetInt("scoreControl");
        losePanel.SetActive(true);
        Time.timeScale = 0f;
        scoreText.GetComponent<Text>().text = "Your Score:" + scoreControlVar.ToString("");
        if (scoreControlVar>highscoreVar)
        {
            PlayerPrefs.SetInt("highScore", scoreControlVar);
            congratsText.GetComponent<Text>().text = "NEW HIGH SCORE";
            congratsText.gameObject.SetActive(true);

        }
        Time.timeScale = 0f;
       
    }
    public void resetHighScore()
    {
        PlayerPrefs.DeleteKey("highScore");

    }
}
