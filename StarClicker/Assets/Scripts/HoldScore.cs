using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldScore : MonoBehaviour
{
    float score;
    float multiplier;
    int stars;
    float fuel;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public float Score { get { return score; } set { score = value; } }
    public float Multiplier { get { return multiplier; } set { multiplier = value; } }
    public int Stars { get { return stars; } set { stars = value; } }
    public float Fuel { get { return fuel; } set { fuel = value; } }
}
