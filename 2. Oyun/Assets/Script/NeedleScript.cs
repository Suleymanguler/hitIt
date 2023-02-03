using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class NeedleScript : MonoBehaviour
{
    
    public int speed = 0;
    public int throwspeed;
    Rigidbody2D fizik;
    public GameObject thisNeedle;
    public GameObject nextNeedle;
    

    void Start()
    {
        speed = 100;
        fizik = GetComponent<Rigidbody2D>();
        throwspeed = 1000;
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
       
    }

    public void ThrowNeedle()
    {
        fizik.AddForce(transform.up * throwspeed);
        speed = 0;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       // Time.timeScale = 0;
        thisNeedle.SetActive(false);
        nextNeedle.SetActive(true);
        
    }

}
