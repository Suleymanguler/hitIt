using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameControl : MonoBehaviour
{
    scoreScript flagVar;
    ParticleSystem flame;
    void Start()
    {
        disableFlame();
        flagVar = FindObjectOfType<scoreScript>();
        flame = GetComponent<ParticleSystem>();
        
    }
    
    private void FixedUpdate()
    {
        if(flagVar.flag==1)
        {

                GetComponent<ParticleSystem>().Play();
                ParticleSystem.EmissionModule em = GetComponent<ParticleSystem>().emission;
                em.enabled = true;
        }
        else if(flagVar.flag==0)
        {
            GetComponent<ParticleSystem>().Play();
            ParticleSystem.EmissionModule em = GetComponent<ParticleSystem>().emission;
            em.enabled = false;
        }
    }

    public void enableFlame()
    {
       // GetComponent<ParticleSystem>().Play();
        //ParticleSystem.EmissionModule em = GetComponent<ParticleSystem>().emission;
        //em.enabled = true;
        flame.enableEmission = true;
    }
    public void disableFlame()
    {
        GetComponent<ParticleSystem>().Stop();
        
        
    }

}
