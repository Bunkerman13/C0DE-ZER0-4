using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateEnd : MonoBehaviour
{
    public GameObject score, mult, fuel, star;

    //display the stats on the end screen
    // Start is called before the first frame update
    void Start()
    {
        score.GetComponent<Text>().text = "Score: " + MySceneManager.Instance.score;

        if (MySceneManager.Instance.multiplier <= 0)
        {
            mult.GetComponent<Text>().text = "Multplier: 0";
        }
        else
        {
            mult.GetComponent<Text>().text = "Multplier: " + MySceneManager.Instance.multiplier;

        }

        if (MySceneManager.Instance.fuel <= 0)
        {
            fuel.GetComponent<Text>().text = "Fuel: 0";
        }
        else
        {
            fuel.GetComponent<Text>().text = "Fuel: " + MySceneManager.Instance.fuel;

        }
        star.GetComponent<Text>().text = "Stars: " + MySceneManager.Instance.stars;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
