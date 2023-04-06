using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    public GameObject pause;
    public GameObject pauseChildren;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void PauseGame() {
        Time.timeScale = 0;
        pause.SetActive(true);
        pauseChildren.SetActive(true);
    }
    public void Resume ()
    {
        Time.timeScale = 1;
        pause.SetActive(false);
        pauseChildren.SetActive(false);
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
