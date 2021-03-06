﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySceneManager : MonoBehaviour //: Singleton<MySceneManager>
{
    // values for determining score
    public float score;
    public float multiplier;
    public int stars;

    public float scorePlus;
    public float multiPlus;
    public int timePlus;

    public int scorePlusLevel;
    public int multiPlusLevel;
    public int timePlusLevel;

    public int scorePlusCost;
    public int multiPlusCost;
    public int timePlusCost;

    public int gameOverValue;


    //Specifically used to draw the gauge
    public float fuel = 100.00f;
    public float time = 1000.00f;
    public FuelGauge fuelGauge;
    public FuelGauge timeGauge;

    // pause
    public bool paused = false;

    // canvas objects
    public GameObject screenCanvas;
    public GameObject storeCanvas;

    // list that holds stars
    public List<GameObject> maxStars;

    // constant values
    const float SPEED = 10;
    const int MAX_STARS = 15;
    // constant accessors
    public float Speed { get { return SPEED; } }
    public float MaxStars { get { return MAX_STARS; } }

    // prefabs for use during game
    public GameObject starNormalPrefab;
    public GameObject starBadPrefab;

    public GameObject scoreUpButton;
    public GameObject multiUpButton;
    public GameObject bonusUpButton;
    public GameObject settingButton;
    public GameObject settingCanvas;

    public GameObject menuButton;
    public GameObject nextButton;
    private void Start()
    {
        screenCanvas = GameObject.FindGameObjectWithTag("screenCanvas");
        storeCanvas = GameObject.FindGameObjectWithTag("storeCanvas");
        Debug.Log(screenCanvas.activeInHierarchy);
        maxStars = new List<GameObject>();
    }
}