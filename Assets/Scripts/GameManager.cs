using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float Food; // The float variable to decrease
    public float Sleep; // The float variable to decrease
    public float Health; // The float variable to decrease
    public float decreaseRate; // The rate at which to decrease the variable

    void Awake()
    {
        Food = 100f;
        Sleep = 100f;
        Health = 100f;
        Debug.Log("First:" + Food);
        Debug.Log("First:" + Sleep);
        Debug.Log("First:" + Health);
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
    }
    IEnumerator DecreaseLoop()
    {
        while (Food > 0f)
        { // Only decrease if variable is above 0
            Food -= decreaseRate;
            yield return new WaitForSeconds(1f);
        }
        while (Sleep > 0f)
        { // Only decrease if variable is above 0
            Food -= decreaseRate;
            yield return new WaitForSeconds(1f);
        }
        while (Health > 0f)
        { // Only decrease if variable is above 0
            Food -= decreaseRate;
            yield return new WaitForSeconds(1f);
        }

    }
}
