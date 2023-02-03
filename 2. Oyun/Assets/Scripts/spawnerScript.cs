using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnerScript : MonoBehaviour
{
    public GameObject targetPrefab;
    public GameObject stickPrefab;
    public int speed;
    public int throwSpeed;
    Rigidbody2D fizik;
    public GameObject stick;
    public Transform[] spawnPoints;
    public GameObject timerBG;
    public GameObject timer;
    public GameObject timeCounter;
    Timer timerScriptVar;
    /*////////////////////////////////////////////////*/
    public GameObject floating10Points;
    public GameObject floating20Points;
    public GameObject floating30Points;
    public GameObject floatingGold;
    public GameObject plusOneImg;
    public GameObject plusTwoImg;
    public GameObject plusThreeImg;
    public GameObject startOffPanel;
    public GameObject pauseMenu;
    public GameObject pauseButton;
    public int speedVar=140;
    
    
    void Start()
    {
        
        Time.timeScale = 1f;
        speed = 160;
        throwSpeed = 65000;
        timerScriptVar = FindObjectOfType<Timer>();
        stick = GameObject.FindGameObjectWithTag("Stick");
        //fizik = stick.GetComponent<Rigidbody2D>();
        
 
    }

    void Update()
    {
     

        stick = GameObject.FindGameObjectWithTag("Stick");
        stick.transform.Rotate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
        fizik = stick.GetComponent<Rigidbody2D>();
        //fizik.MovePosition(fizik.position + new Vector2(0, 1) * throwSpeed * Time.deltaTime);
    }
    
    public void startGame()
    {
    
        startOffPanel.SetActive(false);
        pauseButton.SetActive(true);
        
    }
    public void throwStick()
    {
        speed = 0;
        
        fizik.AddRelativeForce(Vector2.up * throwSpeed*Time.deltaTime);
      

    }
    public void onStickCollide()
    {
        /*
        if (speedVar <= 215)
        {
            speedVar += 5;
        }
        */
        //speed = speedVar;
        timerScriptVar.currentTime = 3f;
        timerScriptVar.comboCounter++;
        GameObject a = Instantiate(stickPrefab,new Vector3(0,0,0), Quaternion.identity);
        stick = GameObject.FindGameObjectWithTag("Stick");
        
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);
        Instantiate(targetPrefab, spawnPoints[randSpawnPoint].position, transform.rotation);
        addGoldFloating();
    }
   public void tenPointsFloating()
    {
        Instantiate(floating10Points, new Vector3(0, 1, 0), Quaternion.identity);
    }
    public void twentyPointsFloating()
    {
        Instantiate(floating20Points, new Vector3(0, 1, 0), Quaternion.identity);
    }
    public void thirtyPointsFloating()
    {
        Instantiate(floating30Points, new Vector3(0, 1, 0), Quaternion.identity);
    }
    public void addGoldFloating()
    {
        Instantiate(floatingGold, new Vector3(1, 1, 0), Quaternion.identity);
    }
    public void plusOne()
    {
        Instantiate(plusOneImg, new Vector3(1, 1, 0), Quaternion.identity);
    }
    public void plusTwo()
    {
        Instantiate(plusTwoImg, new Vector3(1, 1, 0), Quaternion.identity);
    }
    public void plusThree()
    {
        Instantiate(plusThreeImg, new Vector3(1, 1, 0), Quaternion.identity);
    }

    public void pauseGame()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }
    public void resumeGame()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }

}
