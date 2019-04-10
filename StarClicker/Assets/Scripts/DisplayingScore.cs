using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayingScore : MonoBehaviour
{
    public MySceneManager manager;
    // holds text component of this object
    Text textComponent;
    public int displayValue;

    // Start is called before the first frame update
    void Start()
    {
        // sets scoreText to the text component
        textComponent = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {

        manager.timeGauge.SetSize(manager.time / 100);
        //manager.time -= Time.deltaTime;

        // makes sure multiplier doesn't go less than 1 and score doesn't go negative
        if (manager.multiplier < 1f)
            manager.multiplier = 1f;
        if (manager.score < 0)
            manager.score = 0;

        if(displayValue == 1)
        {
            textComponent.text = "Score: " + manager.score;
        }
        else if(displayValue == 2)
        {
            textComponent.text = "Multiplier: " + manager.multiplier;
        }
        else if(displayValue == 3)
        {
            textComponent.text = "Stars: " + manager.stars;
        }

        else if (displayValue == 4)
        {
            textComponent.text = "Fuel: " + Mathf.RoundToInt(manager.fuel);
        }

        else if (displayValue == 5)
        {
            textComponent.text = "Time: " + Mathf.RoundToInt(manager.time);
        }

        // displays the current state of score, multiplier, and amount of stars
        // + "\n" +
        // + "\n" +
        //
    }
}
