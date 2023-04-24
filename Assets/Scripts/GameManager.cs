using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Serialized fields to use for game data
    [SerializeField]  public float Food, Sleep, Health, Happiness, decreaseRate; // The status variables to decrease and the decrease rate
    [SerializeField] public Image bar1, bar2, bar3, bar4; // Status Bar to fill
    void Awake()
    {
        Food = 300f;
        Sleep = 300f;
        Health = 300f;
        Happiness = 300f;
        decreaseRate = 1f;
    }
    void Start()
    {
        StartCoroutine(DecreaseLoopFood());
        StartCoroutine(DecreaseLoopSleep());
        StartCoroutine(DecreaseLoopHealth());
        StartCoroutine(DecreaseLoopHappiness());

    }
    //Coroutine loop that decreases food, sleep and health over time until it reaches 0f
    IEnumerator DecreaseLoopFood()
    {
        while (Food > 0f)
        { // Only decrease if variable is above 0
            Food -= decreaseRate;
            bar1.fillAmount = Food / 300f;
            yield return new WaitForSeconds(1f);
        }
    }
    IEnumerator DecreaseLoopSleep()
    {

        while (Sleep > 0f)
        { // Only decrease if variable is above 0
            Sleep -= decreaseRate;
            bar2.fillAmount = Sleep / 300f;
            yield return new WaitForSeconds(1f);
        }
    }
    IEnumerator DecreaseLoopHealth()
    {

        while (Health > 0f)
        { // Only decrease if variable is above 0
            Health -= decreaseRate;
            bar3.fillAmount = Health / 300f;
            yield return new WaitForSeconds(1f);
        }
    }
    IEnumerator DecreaseLoopHappiness()
    {

        while (Happiness > 0f)
        { // Only decrease if variable is above 0
            Happiness -= decreaseRate;
            bar4.fillAmount = Happiness / 300f;
            yield return new WaitForSeconds(1f);
        }
    
    }

    //Function that increases food to test the coroutine behavior
    void IncreaseFood ()
    {
        GameObject[] objectsWithFoodTag = GameObject.FindGameObjectsWithTag("Food");

        foreach (GameObject obj in objectsWithFoodTag)
        {
            Food = Food + 15f;
        }
    }
}