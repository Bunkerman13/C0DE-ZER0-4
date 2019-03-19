using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayingScore : MonoBehaviour
{
    // holds text component of this object
    Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        // sets scoreText to the text component
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // makes sure multiplier doesn't go less than 1 and score doesn't go negative
        if (MySceneManager.Instance.multiplier < 1f)
            MySceneManager.Instance.multiplier = 1f;
        if (MySceneManager.Instance.score < 0)
            MySceneManager.Instance.score = 0;

        // displays the current state of score, multiplier, and amount of stars
        scoreText.text =
            "Score: " + MySceneManager.Instance.score + "\n" +
            "Multiplier: " + MySceneManager.Instance.multiplier + "\n" +
            "Stars: " + MySceneManager.Instance.stars;
    }
}
