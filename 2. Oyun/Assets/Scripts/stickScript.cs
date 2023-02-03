using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class stickScript : MonoBehaviour
{
    
    
    public GameObject spawner;
    public GameObject stick;
    public GameObject scoreBoard;

    public SpriteRenderer sr;
    public List<Sprite> skins = new List<Sprite>();
    private int selectedSkin;
   // public GameObject playerSkin;
   


    void Start()
    {
        
        stick = GameObject.FindGameObjectWithTag("Stick");
        spawner = GameObject.FindGameObjectWithTag("spawner");
        scoreBoard = GameObject.FindGameObjectWithTag("score");
        // timer = GameObject.FindGameObjectWithTag("timer");
        // timerBG = GameObject.FindGameObjectWithTag("timerBg");
        sr=gameObject.GetComponent<SpriteRenderer>();

        
    }
    

    void Update()
    {
        selectedSkin = PlayerPrefs.GetInt("selectedSkin");

        sr.sprite = skins[selectedSkin];
        
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*spawnerScript ss = gameObject.GetComponent<spawnerScript>();
        ss.onStickCollide();*/
        if (collision.gameObject.tag == "target")
        {
            Destroy(gameObject);
            //stick.SetActive(false);
            spawner.GetComponent<spawnerScript>().onStickCollide();
            scoreBoard.GetComponent<scoreScript>().writeScore();
            
        }
    }
    
}
