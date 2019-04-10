using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateEnd : MonoBehaviour
{
    public GameObject score, mult, fuel, star;
    public MySceneManager manager;

    //display the stats on the end screen
    // Start is called before the first frame update
    void Start()
    {
        score.GetComponent<Text>().text = "Score: " + manager.score;

        if (manager.multiplier <= 0)
        {
            mult.GetComponent<Text>().text = "Multplier: 0";
        }
        else
        {
            mult.GetComponent<Text>().text = "Multplier: " + manager.multiplier;

        }

        if (manager.fuel <= 0)
        {
            fuel.GetComponent<Text>().text = "Fuel: 0";
        }
        else
        {
            fuel.GetComponent<Text>().text = "Fuel: " + manager.fuel;

        }
        star.GetComponent<Text>().text = "Stars: " + manager.stars;
    }

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
