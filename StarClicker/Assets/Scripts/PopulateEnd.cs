using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateEnd : MonoBehaviour
{
    public GameObject score, mult, fuel, star;
    //public MySceneManager manager;
    public HoldScore displayScore;

    //display the stats on the end screen
    // Start is called before the first frame update
    void Start()
    {
        

        
    }

    // Update is called once per frame
    void Update()
    {
        if(displayScore == null)
            displayScore = GameObject.Find("ScoreTransfer(Clone)").GetComponent<HoldScore>();

        score.GetComponent<Text>().text = "Score: " + displayScore.Score;

        if (displayScore.Multiplier <= 0)
        {
            mult.GetComponent<Text>().text = "Multplier: 0";
        }
        else
        {
            mult.GetComponent<Text>().text = "Multplier: " + displayScore.Multiplier;

        }

        if (displayScore.Fuel <= 0)
        {
            fuel.GetComponent<Text>().text = "Fuel: 0";
        }
        else
        {
            fuel.GetComponent<Text>().text = "Fuel: " + displayScore.Fuel;

        }
        star.GetComponent<Text>().text = "Stars: " + displayScore.Stars;
    }
}
