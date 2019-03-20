using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStars : MonoBehaviour
{
    // half width/height of camera/canvas
    float halfHeight;
    float halfWidth;

    // list that holds stars
    List<GameObject> maxStars;

    // Start is called before the first frame update
    void Start()
    {
        // sets variables to half height and width of camera/canvas
        halfHeight = Camera.main.orthographicSize;
        halfWidth = halfHeight * Camera.main.aspect;

        // instantiates list for use
        maxStars = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        // for loop that picks a random number of stars to spawn at once
        // spawns them within the bounds of the camera/canvas
        // **in the future, multiple stars will cross the screen at once
        // **in the future, stars will spawn outside of camera/canvas bounds
        for(int x = 0; x < Random.Range(0,4); x++)
            // stops at 50 stars
            if(maxStars.Count < MySceneManager.Instance.MaxStars)
                // instantiates stars and adds them to a list
                if(Random.Range(0,2) == 0)
                    maxStars.Add(Instantiate(MySceneManager.Instance.starNormalPrefab, new Vector2(Random.Range(-halfWidth, halfWidth), Random.Range(-halfHeight, halfHeight)), Quaternion.identity));
                else
                    maxStars.Add(Instantiate(MySceneManager.Instance.starBadPrefab, new Vector2(Random.Range(-halfWidth, halfWidth), Random.Range(-halfHeight, halfHeight)), Quaternion.identity));
    }
}
