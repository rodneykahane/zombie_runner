using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{

    void Start()
    {
        Invoke("LoadFirstScene", 20f);
    }

    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }

}

    
