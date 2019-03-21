using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStars : MonoBehaviour
{
    // half width/height of camera/canvas
    float halfHeight;
    float halfWidth;

    // Start is called before the first frame update
    void Start()
    {
        // sets variables to half height and width of camera/canvas
        halfHeight = Camera.main.orthographicSize;
        halfWidth = halfHeight * Camera.main.aspect;

        // instantiates list for use
        MySceneManager.Instance.maxStars = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        // for loop that picks a random number of stars to spawn at once
        // spawns them outside the bounds of the camera/canvas
        for(int x = 0; x < Random.Range(0,4); x++)
            // stops at MaxStars
            if(MySceneManager.Instance.maxStars.Count < MySceneManager.Instance.MaxStars)
                // instantiates stars and adds them to a list
                if(Random.Range(0,2) == 0)
                    MySceneManager.Instance.maxStars.Add(Instantiate(MySceneManager.Instance.starNormalPrefab, new Vector2(halfWidth + Random.Range(4f, halfWidth*2.5f), Random.Range(-halfHeight + 2f, halfHeight - 2f)), Quaternion.identity));
                else
                    MySceneManager.Instance.maxStars.Add(Instantiate(MySceneManager.Instance.starBadPrefab, new Vector2(halfWidth + Random.Range(4f, halfWidth*2.5f), Random.Range(-halfHeight + 2f, halfHeight - 2f)), Quaternion.identity));

        ReplaceStar();
    }

    void ReplaceStar()
    {
        for(int x = 0; x < MySceneManager.Instance.maxStars.Count; x++)
        {
            if(MySceneManager.Instance.maxStars[x] == null)
            {
                if (Random.Range(0, 2) == 0)
                    MySceneManager.Instance.maxStars[x] = (Instantiate(MySceneManager.Instance.starNormalPrefab, new Vector2(halfWidth + Random.Range(5f, halfWidth * 2f), Random.Range(-halfHeight + 2f, halfHeight - 2f)), Quaternion.identity));
                else
                    MySceneManager.Instance.maxStars[x] = (Instantiate(MySceneManager.Instance.starBadPrefab, new Vector2(halfWidth + Random.Range(5f, halfWidth * 2f), Random.Range(-halfHeight + 2f, halfHeight - 2f)), Quaternion.identity));

            }
        }
    }
}
