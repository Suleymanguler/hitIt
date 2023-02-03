using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetScript : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(true);
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        //gameObject.SetActive(false);
    }
}
