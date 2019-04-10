using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HandleStore : MonoBehaviour
{
    public MySceneManager manager;
    // Start is called before the first frame update
    /*public static*/ void Start/*Game*/()
    {
        manager = GameObject.FindGameObjectWithTag("OriginalSceneManager").GetComponent<MySceneManager>();
        manager.scoreUpButton.GetComponentInChildren<Text>().text = "SCORE UP\nLvl: " + manager.scorePlusLevel.ToString() + " Cost: " + manager.scorePlusCost.ToString();
        manager.bonusUpButton.GetComponentInChildren<Text>().text = "BONUS UP\nLvl: " + manager.timePlusLevel.ToString() + " Cost: " + manager.timePlusCost.ToString();
        manager.multiUpButton.GetComponentInChildren<Text>().text = "MULTIPLIER UP\nLvl: " + manager.multiPlusLevel.ToString() + " Cost: " + manager.multiPlusCost.ToString();

        manager.scoreUpButton.SetActive(false);
        manager.bonusUpButton.SetActive(false);
        manager.multiUpButton.SetActive(false);
        manager.settingButton.SetActive(false);

        manager.menuButton.SetActive(false);
        manager.nextButton.SetActive(false);

        //manager.backscorebutton.SetActive(false);
        //manager.MainMenubutton.SetActive(false);
    }

    ////// Update is called once per frame
    //void Update()
    //{



    //}
    public void ClickEnter()
    {
        manager.scoreUpButton.SetActive(true);
        manager.bonusUpButton.SetActive(true);
        manager.multiUpButton.SetActive(true);

        manager.settingButton.SetActive(true);

        manager.paused = !manager.paused;
        manager.storeCanvas.GetComponent<Canvas>().sortingOrder = 2;

        Image storeBackground = GameObject.Find("StoreBackground").GetComponent<Image>();

        manager.scoreUpButton.GetComponentInChildren<Text>().text = "SCORE UP\nLvl: " + manager.scorePlusLevel.ToString() + " Cost: " + manager.scorePlusCost.ToString();
        manager.bonusUpButton.GetComponentInChildren<Text>().text = "BONUS UP\nLvl: " + manager.timePlusLevel.ToString() + " Cost: " + manager.timePlusCost.ToString();
        manager.multiUpButton.GetComponentInChildren<Text>().text = "MULTIPLIER UP\nLvl: " + manager.multiPlusLevel.ToString() + " Cost: " + manager.multiPlusCost.ToString();

        // makes image solid
        Color tempColor = storeBackground.color;
        tempColor.a = 1f;
        storeBackground.color = tempColor;



        // toggles raycast target (allow it to be clicked or not)
        storeBackground.raycastTarget = !storeBackground.raycastTarget;
    }

    public void ClickExit()
    {
        manager.paused = !manager.paused;
        manager.storeCanvas.GetComponent<Canvas>().sortingOrder = -2;

        Image storeBackground = GameObject.Find("StoreBackground").GetComponent<Image>();

        // makes image transparent
        Color tempColor = storeBackground.color;
        tempColor.a = 0f;
        storeBackground.color = tempColor;

        manager.scoreUpButton.SetActive(false);
        manager.bonusUpButton.SetActive(false);
        manager.multiUpButton.SetActive(false);
        manager.settingButton.SetActive(false);

        // toggles raycast target (allow it to be clicked or not)
        storeBackground.raycastTarget = !storeBackground.raycastTarget;
    }

    ////Increases score gained from star cicks
    public void ClickScoreUp()
    {
        float buyScore = manager.score;

        if (buyScore >= manager.scorePlusCost)
        {
            manager.score = manager.score - manager.scorePlusCost;
            manager.scorePlusLevel += 1;
            manager.scorePlusCost = (manager.scorePlusCost * 2);


            manager.scoreUpButton.GetComponentInChildren<Text>().text = "SCORE UP\nLvl: " + manager.scorePlusLevel.ToString() + " Cost: " + manager.scorePlusCost.ToString();
            manager.bonusUpButton.GetComponentInChildren<Text>().text = "BONUS UP\nLvl: " + manager.timePlusLevel.ToString() + " Cost: " + manager.timePlusCost.ToString();
            manager.multiUpButton.GetComponentInChildren<Text>().text = "MULTIPLIER UP\nLvl: " + manager.multiPlusLevel.ToString() + " Cost: " + manager.multiPlusCost.ToString();

        }

    }

    //Increases the amount the multiplier increases by
    public void ClickMultiUp()
    {
        float buyScore = manager.score;
        if (buyScore >= manager.multiPlusCost)
        {
            manager.score = manager.score - manager.multiPlusCost;
            manager.multiPlusLevel += 1;
            manager.multiPlusCost = (manager.multiPlusCost * 2);

            manager.scoreUpButton.GetComponentInChildren<Text>().text = "SCORE UP\nLvl: " + manager.scorePlusLevel.ToString() + " Cost: " + manager.scorePlusCost.ToString();
            manager.bonusUpButton.GetComponentInChildren<Text>().text = "BONUS UP\nLvl: " + manager.timePlusLevel.ToString() + " Cost: " + manager.timePlusCost.ToString();
            manager.multiUpButton.GetComponentInChildren<Text>().text = "MULTIPLIER UP\nLvl: " + manager.multiPlusLevel.ToString() + " Cost: " + manager.multiPlusCost.ToString();

        }

    }

    //Increases the points the player earns over time
    public void ClickBonusUp()
    {
        float buyScore = manager.score;
        if (buyScore >= manager.timePlusCost)
        {
            Debug.Log(manager.timePlusCost);
            Debug.Log(manager.timePlusLevel);

            manager.score = manager.score - manager.timePlusCost;
            manager.timePlusLevel += 1;
            manager.timePlusCost = (manager.timePlusCost * 2);

            Debug.Log(manager.timePlusCost);
            Debug.Log(manager.timePlusLevel);

            manager.scoreUpButton.GetComponentInChildren<Text>().text = "SCORE UP\nLvl: " + manager.scorePlusLevel.ToString() + " Cost: " + manager.scorePlusCost.ToString();
            manager.bonusUpButton.GetComponentInChildren<Text>().text = "BONUS UP\nLvl: " + manager.timePlusLevel.ToString() + " Cost: " + manager.timePlusCost.ToString();
            manager.multiUpButton.GetComponentInChildren<Text>().text = "MULTIPLIER UP\nLvl: " + manager.multiPlusLevel.ToString() + " Cost: " + manager.multiPlusCost.ToString();

        }
    }
    public void Setting()
    {
        manager.settingCanvas.GetComponent<Canvas>().sortingOrder = 3;
        manager.storeCanvas.GetComponent<Canvas>().sortingOrder = -2;

        manager.settingCanvas.SetActive(true);
        //manager.backscorebutton.SetActive(true);
        //manager.MainMenubutton.SetActive(true);
    }
    public void falseSetting()
    {
        manager.settingCanvas.GetComponent<Canvas>().sortingOrder = -3;
        manager.storeCanvas.GetComponent<Canvas>().sortingOrder = 2;
        manager.settingCanvas.SetActive(false);
        manager.scoreUpButton.SetActive(true);
        manager.multiUpButton.SetActive(true);
        manager.bonusUpButton.SetActive(true);
        manager.settingButton.SetActive(true);
        //manager.backscorebutton.SetActive(false);
        //manager.MainMenubutton.SetActive(false);
    }
    public void Menue()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }


    public void pickOne()
    {
        manager.fuel = 100.0f;
        manager.time = 1000.0f;

        for (int x = 0; x < manager.maxStars.Count; x++)
        {
            Destroy(manager.maxStars[x].gameObject);
        }

        manager.menuButton.SetActive(true);
        manager.nextButton.SetActive(true);

        manager.paused = !manager.paused;
        manager.storeCanvas.GetComponent<Canvas>().sortingOrder = 2;

        Image storeBackground = GameObject.Find("StoreBackground").GetComponent<Image>();

        Color tempColor = storeBackground.color;
        tempColor.a = 1f;
        storeBackground.color = tempColor;

        // toggles raycast target (allow it to be clicked or not)
        storeBackground.raycastTarget = !storeBackground.raycastTarget;
    }

    public void ClickMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ClickNext()
    {
        manager.menuButton.SetActive(false);
        manager.nextButton.SetActive(false);
        manager.paused = !manager.paused;
        manager.storeCanvas.GetComponent<Canvas>().sortingOrder = -2;

        Image storeBackground = GameObject.Find("StoreBackground").GetComponent<Image>();

        // makes image transparent
        Color tempColor = storeBackground.color;
        tempColor.a = 0f;
        storeBackground.color = tempColor;

        // toggles raycast target (allow it to be clicked or not)
        storeBackground.raycastTarget = !storeBackground.raycastTarget;
    }
}
