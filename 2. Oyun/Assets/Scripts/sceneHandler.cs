using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class sceneHandler : MonoBehaviour
{
   

    public void restartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scene1");
    }
}
