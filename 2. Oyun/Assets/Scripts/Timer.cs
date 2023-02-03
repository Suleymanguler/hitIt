using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float currentTime;
    public float startingTime = 3f;
    public int comboCounter;
    public ParticleSystem flameEffect;
    public GameObject flameObject;
    public Text comboText2;
    public Text comboText3;

    spawnerScript spawnerScript2;
    void Start()
    {
        startingTime = 0f;
        currentTime = startingTime;
        spawnerScript2=FindObjectOfType<spawnerScript>();
        
    }
    void Update()
    {
       
        currentTime += -1 * Time.deltaTime;
        //countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            
            flameObject = GameObject.FindGameObjectWithTag("Flame");
            //flameEffect = flameObject.GetComponent<ParticleSystem>();
            ParticleSystem.EmissionModule em = flameObject.GetComponent<ParticleSystem>().emission;
            em.enabled = false;
            currentTime = 0;
            comboCounter = 0;
            comboText2.gameObject.SetActive(false);
            comboText3.gameObject.SetActive(false);
            //spawnerScript2.speed = 130;
           
        }
    }
}
