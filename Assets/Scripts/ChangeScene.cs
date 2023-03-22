using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Quit () 
    {
        Application.Quit();
    }
}
