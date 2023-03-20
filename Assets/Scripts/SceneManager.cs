using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

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
}
