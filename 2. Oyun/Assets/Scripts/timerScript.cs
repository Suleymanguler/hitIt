using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerScript : MonoBehaviour
{
    private Image comboTimer;
    public float currentTime2;
    private float maxTime=3f;
    Timer timerForCombo;
    void Start()
    {
        comboTimer = GetComponent<Image>();
        timerForCombo = FindObjectOfType<Timer>();
        

    }

    void Update()
    {
        currentTime2 = timerForCombo.currentTime;
        comboTimer.fillAmount = currentTime2 / maxTime;
            
            
    }
}
