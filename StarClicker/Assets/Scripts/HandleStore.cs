using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleStore : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

        //Displays prices and levels for power ups
        Button scoreUp = GameObject.FindGameObjectWithTag("Score").GetComponent<Button>();
        Button multiUp = GameObject.FindGameObjectWithTag("Multiply").GetComponent<Button>();
        Button bonusUp = GameObject.FindGameObjectWithTag("Bonus").GetComponent<Button>();

        scoreUp.gameObject.GetComponentInChildren<Text>().text="SCORE UP\nLvl: " + MySceneManager.Instance.scorePlusLevel.ToString()+" Cost: " + MySceneManager.Instance.scorePlusCost.ToString();
        bonusUp.gameObject.GetComponentInChildren<Text>().text = "BONUS UP\nLvl: " + MySceneManager.Instance.timePlusLevel.ToString() + " Cost: " + MySceneManager.Instance.timePlusCost.ToString(); 
        multiUp.gameObject.GetComponentInChildren<Text>().text = "MULTIPLIER UP\nLvl: " + MySceneManager.Instance.multiPlusLevel.ToString() + " Cost: " + MySceneManager.Instance.multiPlusCost.ToString(); 
        


        scoreUp.gameObject.SetActive(false);
        multiUp.gameObject.SetActive(false);
        bonusUp.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void ClickEnter()
    {
        MySceneManager.Instance.paused = !MySceneManager.Instance.paused;
        MySceneManager.Instance.storeCanvas.GetComponent<Canvas>().sortingOrder = 2;

        Image storeBackground = GameObject.Find("StoreBackground").GetComponent<Image>();

        Button scoreUp = GameObject.Find("ScoreUp").GetComponent<Button>();
        Button multiUp = GameObject.Find("MultiplyUP").GetComponent<Button>();
        Button bonusUp = GameObject.Find("BonusUp").GetComponent<Button>();

        scoreUp.gameObject.GetComponentInChildren<Text>().text = "SCORE UP\nLvl: " + MySceneManager.Instance.scorePlusLevel.ToString() + " Cost: " + MySceneManager.Instance.scorePlusCost.ToString();
        bonusUp.gameObject.GetComponentInChildren<Text>().text = "BONUS UP\nLvl: " + MySceneManager.Instance.timePlusLevel.ToString() + " Cost: " + MySceneManager.Instance.timePlusCost.ToString();
        multiUp.gameObject.GetComponentInChildren<Text>().text = "MULTIPLIER UP\nLvl: " + MySceneManager.Instance.multiPlusLevel.ToString() + " Cost: " + MySceneManager.Instance.multiPlusCost.ToString();

        // makes image solid
        Color tempColor = storeBackground.color;
        tempColor.a = 1f;
        storeBackground.color = tempColor;

        scoreUp.gameObject.SetActive(true);
        multiUp.gameObject.SetActive(true);
        bonusUp.gameObject.SetActive(true);

        // toggles raycast target (allow it to be clicked or not)
        storeBackground.raycastTarget = !storeBackground.raycastTarget;
    }

    public void ClickExit()
    {
        MySceneManager.Instance.paused = !MySceneManager.Instance.paused;
        MySceneManager.Instance.storeCanvas.GetComponent<Canvas>().sortingOrder = -2;

        Image storeBackground = GameObject.Find("StoreBackground").GetComponent<Image>();

        Button scoreUp = GameObject.Find("ScoreUp").GetComponent<Button>();
        Button multiUp = GameObject.Find("MultiplyUP").GetComponent<Button>();
        Button bonusUp = GameObject.Find("BonusUp").GetComponent<Button>();

        // makes image transparent
        Color tempColor = storeBackground.color;
        tempColor.a = 0f;
        storeBackground.color = tempColor;

        scoreUp.gameObject.SetActive(false);
        multiUp.gameObject.SetActive(false);
        bonusUp.gameObject.SetActive(false);

        // toggles raycast target (allow it to be clicked or not)
        storeBackground.raycastTarget = !storeBackground.raycastTarget;
    }

    //Increases score gained from star cicks
    public void ClickScoreUp()
    {
        float buyScore=MySceneManager.Instance.score;

        if(buyScore>= MySceneManager.Instance.scorePlusCost)
        {
            MySceneManager.Instance.score = MySceneManager.Instance.score - MySceneManager.Instance.scorePlusCost;
            MySceneManager.Instance.scorePlusLevel += 1;
            MySceneManager.Instance.scorePlusCost *= MySceneManager.Instance.scorePlusCost;

            Button scoreUp = GameObject.Find("ScoreUp").GetComponent<Button>();
            Button multiUp = GameObject.Find("MultiplyUP").GetComponent<Button>();
            Button bonusUp = GameObject.Find("BonusUp").GetComponent<Button>();

            scoreUp.gameObject.GetComponentInChildren<Text>().text = "SCORE UP\nLvl: " + MySceneManager.Instance.scorePlusLevel.ToString() + " Cost: " + MySceneManager.Instance.scorePlusCost.ToString();
            bonusUp.gameObject.GetComponentInChildren<Text>().text = "BONUS UP\nLvl: " + MySceneManager.Instance.timePlusLevel.ToString() + " Cost: " + MySceneManager.Instance.timePlusCost.ToString();
            multiUp.gameObject.GetComponentInChildren<Text>().text = "MULTIPLIER UP\nLvl: " + MySceneManager.Instance.multiPlusLevel.ToString() + " Cost: " + MySceneManager.Instance.multiPlusCost.ToString();

        }

    }

    //Increases the amount the multiplier increases by
    public void ClickMultiUp()
    {
        float buyScore = MySceneManager.Instance.score;
        if (buyScore >= MySceneManager.Instance.multiPlusCost)
        {
            MySceneManager.Instance.score = MySceneManager.Instance.score - MySceneManager.Instance.multiPlusCost;
            MySceneManager.Instance.multiPlusLevel += 1;
            MySceneManager.Instance.multiPlusCost *= MySceneManager.Instance.multiPlusCost;

            Button scoreUp = GameObject.Find("ScoreUp").GetComponent<Button>();
            Button multiUp = GameObject.Find("MultiplyUP").GetComponent<Button>();
            Button bonusUp = GameObject.Find("BonusUp").GetComponent<Button>();

            scoreUp.gameObject.GetComponentInChildren<Text>().text = "SCORE UP\nLvl: " + MySceneManager.Instance.scorePlusLevel.ToString() + " Cost: " + MySceneManager.Instance.scorePlusCost.ToString();
            bonusUp.gameObject.GetComponentInChildren<Text>().text = "BONUS UP\nLvl: " + MySceneManager.Instance.timePlusLevel.ToString() + " Cost: " + MySceneManager.Instance.timePlusCost.ToString();
            multiUp.gameObject.GetComponentInChildren<Text>().text = "MULTIPLIER UP\nLvl: " + MySceneManager.Instance.multiPlusLevel.ToString() + " Cost: " + MySceneManager.Instance.multiPlusCost.ToString();

        }

    }

    //Increases the points the player earns over time
    public void ClickBonusUp()
    {
        float buyScore = MySceneManager.Instance.score;
        if (buyScore >= MySceneManager.Instance.timePlusCost)
        {
            MySceneManager.Instance.score = MySceneManager.Instance.score - MySceneManager.Instance.timePlusCost;
            MySceneManager.Instance.timePlusLevel += 1;
            MySceneManager.Instance.timePlusCost *= MySceneManager.Instance.timePlusCost;

            Button scoreUp = GameObject.Find("ScoreUp").GetComponent<Button>();
            Button multiUp = GameObject.Find("MultiplyUP").GetComponent<Button>();
            Button bonusUp = GameObject.Find("BonusUp").GetComponent<Button>();

            scoreUp.gameObject.GetComponentInChildren<Text>().text = "SCORE UP\nLvl: " + MySceneManager.Instance.scorePlusLevel.ToString() + " Cost: " + MySceneManager.Instance.scorePlusCost.ToString();
            bonusUp.gameObject.GetComponentInChildren<Text>().text = "BONUS UP\nLvl: " + MySceneManager.Instance.timePlusLevel.ToString() + " Cost: " + MySceneManager.Instance.timePlusCost.ToString();
            multiUp.gameObject.GetComponentInChildren<Text>().text = "MULTIPLIER UP\nLvl: " + MySceneManager.Instance.multiPlusLevel.ToString() + " Cost: " + MySceneManager.Instance.multiPlusCost.ToString();

        }
    }

}
