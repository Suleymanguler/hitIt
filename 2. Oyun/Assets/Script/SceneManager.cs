using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class SceneManager : MonoBehaviour
{
    public GameObject pausePanel;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void LoadLevel1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
        Time.timeScale = 1;
    }
    public void LoadLevel2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level2");
        Time.timeScale = 1;
    }
    public void LoadLevel3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level3");
        Time.timeScale = 1;
    }
    public void LoadLevel4()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level4");
        Time.timeScale = 1;
    }
    public void LoadLevel5()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level5");
        Time.timeScale = 1;
    }
    public void resumeGame()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void backtoMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
    public void pauseGame()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }
   
    public void ChooseLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Levels");
    }
    public void quitGame()
    {
        Application.Quit();
    }
        


}
