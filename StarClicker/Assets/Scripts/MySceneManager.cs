using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySceneManager : Singleton<MySceneManager>
{
    // values for determining score
    public float score;
    public float multiplier;
    public int stars;

    // pause
    public bool paused = false;

    // canvas objects
    public GameObject screenCanvas;
    public GameObject storeCanvas;

    // constant values
    const float SPEED = 10;
    const int MAX_STARS = 50;
    // constant accessors
    public float Speed { get { return SPEED; } }
    public float MaxStars { get { return MAX_STARS; } }

    // prefabs for use during game
    public GameObject starNormalPrefab;
    public GameObject starBadPrefab;
}
