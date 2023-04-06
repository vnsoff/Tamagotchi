using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Serialized fields to use for game data
    [SerializeField]  public float Food; // The float variable to decrease Food
    [SerializeField]  public float Sleep; // The float variable to decrease Sleep
    [SerializeField]  public float Health; // The float variable to decrease Health
    [SerializeField]  public float Happiness; // The float variable to decrease Happiness
    [SerializeField]  public float decreaseRate; // The rate to decrease the variable
    [SerializeField] public Image bar1; // Bar
    [SerializeField] public Image bar2; // Bar
    [SerializeField] public Image bar3; // Bar
    [SerializeField] public Image bar4; // Bar

    void Awake()
    {
        Food = 100f;
        Sleep = 100f;
        Health = 100f;
        decreaseRate = 5f;
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
            bar1.fillAmount = Food / 100f;
            yield return new WaitForSeconds(1f);
        }
        while (Sleep > 0f)
        { // Only decrease if variable is above 0
            Sleep -= decreaseRate;
            bar2.fillAmount = Sleep / 100f;
            yield return new WaitForSeconds(1f);
        }
        while (Health > 0f)
        { // Only decrease if variable is above 0
            Health -= decreaseRate;
            bar3.fillAmount = Health / 100f;
            yield return new WaitForSeconds(1f);
        }
        while (Happiness > 0f)
        { // Only decrease if variable is above 0
            Happiness -= decreaseRate;
            bar4.fillAmount = Happiness / 100f;
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