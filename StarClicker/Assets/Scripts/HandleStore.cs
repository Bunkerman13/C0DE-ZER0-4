using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleStore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MySceneManager.Instance.scoreUpButton.GetComponentInChildren<Text>().text = "SCORE UP\nLvl: " + MySceneManager.Instance.scorePlusLevel.ToString() + " Cost: " + MySceneManager.Instance.scorePlusCost.ToString();
        MySceneManager.Instance.bonusUpButton.GetComponentInChildren<Text>().text = "BONUS UP\nLvl: " + MySceneManager.Instance.timePlusLevel.ToString() + " Cost: " + MySceneManager.Instance.timePlusCost.ToString();
        MySceneManager.Instance.multiUpButton.GetComponentInChildren<Text>().text = "MULTIPLIER UP\nLvl: " + MySceneManager.Instance.multiPlusLevel.ToString() + " Cost: " + MySceneManager.Instance.multiPlusCost.ToString();

        MySceneManager.Instance.scoreUpButton.SetActive(false);
        MySceneManager.Instance.bonusUpButton.SetActive(false);
        MySceneManager.Instance.multiUpButton.SetActive(false);
    }

    //// Update is called once per frame
    void Update()
    {



    }

    public void ClickEnter()
    {
        MySceneManager.Instance.paused = !MySceneManager.Instance.paused;
        MySceneManager.Instance.storeCanvas.GetComponent<Canvas>().sortingOrder = 2;

        Image storeBackground = GameObject.Find("StoreBackground").GetComponent<Image>();

        MySceneManager.Instance.scoreUpButton.GetComponentInChildren<Text>().text = "SCORE UP\nLvl: " + MySceneManager.Instance.scorePlusLevel.ToString() + " Cost: " + MySceneManager.Instance.scorePlusCost.ToString();
        MySceneManager.Instance.bonusUpButton.GetComponentInChildren<Text>().text = "BONUS UP\nLvl: " + MySceneManager.Instance.timePlusLevel.ToString() + " Cost: " + MySceneManager.Instance.timePlusCost.ToString();
        MySceneManager.Instance.multiUpButton.GetComponentInChildren<Text>().text = "MULTIPLIER UP\nLvl: " + MySceneManager.Instance.multiPlusLevel.ToString() + " Cost: " + MySceneManager.Instance.multiPlusCost.ToString();

        // makes image solid
        Color tempColor = storeBackground.color;
        tempColor.a = 1f;
        storeBackground.color = tempColor;

        MySceneManager.Instance.scoreUpButton.SetActive(true);
        MySceneManager.Instance.bonusUpButton.SetActive(true);
        MySceneManager.Instance.multiUpButton.SetActive(true);

        // toggles raycast target (allow it to be clicked or not)
        storeBackground.raycastTarget = !storeBackground.raycastTarget;
    }

    public void ClickExit()
    {
        MySceneManager.Instance.paused = !MySceneManager.Instance.paused;
        MySceneManager.Instance.storeCanvas.GetComponent<Canvas>().sortingOrder = -2;

        Image storeBackground = GameObject.Find("StoreBackground").GetComponent<Image>();

        // makes image transparent
        Color tempColor = storeBackground.color;
        tempColor.a = 0f;
        storeBackground.color = tempColor;

        MySceneManager.Instance.scoreUpButton.SetActive(false);
        MySceneManager.Instance.bonusUpButton.SetActive(false);
        MySceneManager.Instance.multiUpButton.SetActive(false);

        // toggles raycast target (allow it to be clicked or not)
        storeBackground.raycastTarget = !storeBackground.raycastTarget;
    }

    ////Increases score gained from star cicks
    public void ClickScoreUp()
    {
        float buyScore = MySceneManager.Instance.score;

        if (buyScore >= MySceneManager.Instance.scorePlusCost)
        {
            MySceneManager.Instance.score = MySceneManager.Instance.score - MySceneManager.Instance.scorePlusCost;
            MySceneManager.Instance.scorePlusLevel += 1;
            MySceneManager.Instance.scorePlusCost = (MySceneManager.Instance.scorePlusCost * 2);


            MySceneManager.Instance.scoreUpButton.GetComponentInChildren<Text>().text = "SCORE UP\nLvl: " + MySceneManager.Instance.scorePlusLevel.ToString() + " Cost: " + MySceneManager.Instance.scorePlusCost.ToString();
            MySceneManager.Instance.bonusUpButton.GetComponentInChildren<Text>().text = "BONUS UP\nLvl: " + MySceneManager.Instance.timePlusLevel.ToString() + " Cost: " + MySceneManager.Instance.timePlusCost.ToString();
            MySceneManager.Instance.multiUpButton.GetComponentInChildren<Text>().text = "MULTIPLIER UP\nLvl: " + MySceneManager.Instance.multiPlusLevel.ToString() + " Cost: " + MySceneManager.Instance.multiPlusCost.ToString();

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
            MySceneManager.Instance.multiPlusCost = (MySceneManager.Instance.multiPlusCost * 2);

            MySceneManager.Instance.scoreUpButton.GetComponentInChildren<Text>().text = "SCORE UP\nLvl: " + MySceneManager.Instance.scorePlusLevel.ToString() + " Cost: " + MySceneManager.Instance.scorePlusCost.ToString();
            MySceneManager.Instance.bonusUpButton.GetComponentInChildren<Text>().text = "BONUS UP\nLvl: " + MySceneManager.Instance.timePlusLevel.ToString() + " Cost: " + MySceneManager.Instance.timePlusCost.ToString();
            MySceneManager.Instance.multiUpButton.GetComponentInChildren<Text>().text = "MULTIPLIER UP\nLvl: " + MySceneManager.Instance.multiPlusLevel.ToString() + " Cost: " + MySceneManager.Instance.multiPlusCost.ToString();

        }

    }

    //Increases the points the player earns over time
    public void ClickBonusUp()
    {
        float buyScore = MySceneManager.Instance.score;
        if (buyScore >= MySceneManager.Instance.timePlusCost)
        {
            Debug.Log(MySceneManager.Instance.timePlusCost);
            Debug.Log(MySceneManager.Instance.timePlusLevel);

            MySceneManager.Instance.score = MySceneManager.Instance.score - MySceneManager.Instance.timePlusCost;
            MySceneManager.Instance.timePlusLevel += 1;
            MySceneManager.Instance.timePlusCost = (MySceneManager.Instance.timePlusCost * 2);

            Debug.Log(MySceneManager.Instance.timePlusCost);
            Debug.Log(MySceneManager.Instance.timePlusLevel);

            MySceneManager.Instance.scoreUpButton.GetComponentInChildren<Text>().text = "SCORE UP\nLvl: " + MySceneManager.Instance.scorePlusLevel.ToString() + " Cost: " + MySceneManager.Instance.scorePlusCost.ToString();
            MySceneManager.Instance.bonusUpButton.GetComponentInChildren<Text>().text = "BONUS UP\nLvl: " + MySceneManager.Instance.timePlusLevel.ToString() + " Cost: " + MySceneManager.Instance.timePlusCost.ToString();
            MySceneManager.Instance.multiUpButton.GetComponentInChildren<Text>().text = "MULTIPLIER UP\nLvl: " + MySceneManager.Instance.multiPlusLevel.ToString() + " Cost: " + MySceneManager.Instance.multiPlusCost.ToString();

        }
    }

}
