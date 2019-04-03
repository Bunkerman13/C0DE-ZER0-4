using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayingScore : MonoBehaviour
{
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

        // makes sure multiplier doesn't go less than 1 and score doesn't go negative
        if (MySceneManager.Instance.multiplier < 1f)
            MySceneManager.Instance.multiplier = 1f;
        if (MySceneManager.Instance.score < 0)
            MySceneManager.Instance.score = 0;

        if(displayValue == 1)
        {
            textComponent.text = "Score: " + MySceneManager.Instance.score;
        }
        else if(displayValue == 2)
        {
            textComponent.text = "Multiplier: " + MySceneManager.Instance.multiplier;
        }
        else if(displayValue == 3)
        {
            textComponent.text = "Stars: " + MySceneManager.Instance.stars;
        }

        else if (displayValue == 4)
        {
            textComponent.text = "Fuel: " + MySceneManager.Instance.fuel;
        }

        // displays the current state of score, multiplier, and amount of stars
        // + "\n" +
            // + "\n" +
            //
    }
}
