using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySceneManager : Singleton<MySceneManager>
{
    // values for determining score
    float score;
    float multiplier;
    int stars;

    // prefabs for use during game
    public GameObject starNormalPrefab;
    public GameObject starBadPrefab;
}
