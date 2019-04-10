using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStars : MonoBehaviour
{
    // half width/height of camera/canvas
    float halfHeight;
    float halfWidth;
    public MySceneManager manager;
    // Start is called before the first frame update
    void Start()
    {
        // sets variables to half height and width of camera/canvas
        halfHeight = Camera.main.orthographicSize;
        halfWidth = halfHeight * Camera.main.aspect;

        // instantiates list for use
        manager.maxStars = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        // for loop that picks a random number of stars to spawn at once
        // spawns them outside the bounds of the camera/canvas
        for(int x = 0; x < Random.Range(0,4); x++)
            // stops at MaxStars
            if(manager.maxStars.Count < manager.MaxStars)
                // instantiates stars and adds them to a list
                if(Random.Range(0,2) == 0)
                    manager.maxStars.Add(Instantiate(manager.starNormalPrefab, new Vector2(halfWidth + Random.Range(4f, halfWidth*2.5f), Random.Range(-halfHeight + 2f, halfHeight - 2f)), Quaternion.identity));
                else
                    manager.maxStars.Add(Instantiate(manager.starBadPrefab, new Vector2(halfWidth + Random.Range(4f, halfWidth*2.5f), Random.Range(-halfHeight + 2f, halfHeight - 2f)), Quaternion.identity));

        ReplaceStar();
    }

    void ReplaceStar()
    {
        for(int x = 0; x < manager.maxStars.Count; x++)
        {
            if(manager.maxStars[x] == null)
            {
                if (Random.Range(0, 2) == 0)
                    manager.maxStars[x] = (Instantiate(manager.starNormalPrefab, new Vector2(halfWidth + Random.Range(5f, halfWidth * 2f), Random.Range(-halfHeight + 2f, halfHeight)), Quaternion.identity));
                else
                    manager.maxStars[x] = (Instantiate(manager.starBadPrefab, new Vector2(halfWidth + Random.Range(5f, halfWidth * 2f), Random.Range(-halfHeight + 2f, halfHeight)), Quaternion.identity));

            }
        }
    }
}
