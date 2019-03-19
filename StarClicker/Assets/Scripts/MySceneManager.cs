using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySceneManager : Singleton<MySceneManager>
{
    // values for determining score
    public float score;
    public float multiplier;
    public int stars;

    // prefabs for use during game
    public GameObject starNormalPrefab;
    public GameObject starBadPrefab;
}
