using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{
    public string name;
    private int happiness;
    private int hunger;
    private int thirst;
    private float health;
    private bool isHealthy;
    private bool isThirst;

    void Start ()
    {
        Debug.Log("Name: " + name);
        Debug.Log("Happiness: " + happiness);
        Debug.Log("Hunger: " + hunger);
        Debug.Log("Thirst: " + thirst);
        Debug.Log("Is Healthy: " + isHealthy);
    }
    void Update ()
    { 
        
    }
}
