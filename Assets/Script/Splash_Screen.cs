using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash_Screen : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadMainMenu", 4);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(1);
    }

    void Update()
    {
        
    }
}
