using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Serialized fields to use for game data
    [SerializeField]  public float Food; // The float variable to decrease Food
    [SerializeField]  public float Sleep; // The float variable to decrease Sleep
    [SerializeField]  public float Health; // The float variable to decrease Health
    [SerializeField]  public float Happiness; // The float variable to decrease Happiness
    [SerializeField]  public float decreaseRate; // The rate to decrease the variable

    void Awake()
    {
        Food = 5f;
        Sleep = 100f;
        Health = 100f;
        decreaseRate = 1f;
        Debug.Log("First:" + Food);
        Debug.Log("First:" + Sleep);
        Debug.Log("First:" + Health);
        Debug.Log("First:" + Happiness);

    }
    void Start()
    {
        StartCoroutine(DecreaseLoop());
    }
    private void Update()
    {
        Debug.Log(Food);
        Debug.Log(Sleep);
        Debug.Log(Health);
        Debug.Log(Happiness);
    }
    //Coroutine loop that decreases food, sleep and health over time until it reaches 0f
    IEnumerator DecreaseLoop()
    {
        while (Food > 0f)
        { // Only decrease if variable is above 0
            Food -= decreaseRate;
            yield return new WaitForSeconds(1f);
        }
        while (Sleep > 0f)
        { // Only decrease if variable is above 0
            Sleep -= decreaseRate;
            yield return new WaitForSeconds(1f);
        }
        while (Health > 0f)
        { // Only decrease if variable is above 0
            Health -= decreaseRate;
            yield return new WaitForSeconds(1f);
        }
        while (Happiness > 0f)
        { // Only decrease if variable is above 0
            Happiness -= decreaseRate;
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