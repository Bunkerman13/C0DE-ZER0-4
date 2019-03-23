﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchClick : MonoBehaviour
{
    // **designated when stars are located
    // in the pregabs folder
    // used to identify which star is which
    public int starIdentifier;

    // Update is called once per frame
    void Update()
    {
        TouchInput();
    }

    /*
     * TouchInput
     * FUNCTION:
     * checks if user has touhced the screen
     * and checks if it is colliding with this object
     */
    void TouchInput()
    {
        // checks if there is at least 1 touch occuring
        if(Input.touchCount > 0)
        {
            // checks if the first touch phase is the "Began" phase (touch is first detected)
            if(Input.touches[0].phase == TouchPhase.Began)
            {
                // gets position of touch on screen and translates it to world position
                var worldPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                // creates new 2d vector for tanslated touch position
                var touchPosition = new Vector2(worldPosition.x, worldPosition.y);

                // checks if position of touch overlaps collider of this object
                if (GetComponent<CircleCollider2D>() == Physics2D.OverlapPoint(touchPosition))
                {
                    // calls IdentifyStar function to effect the game
                    // based on whichever star is chosen
                    IdentifyStar(starIdentifier);
                    Destroy(gameObject);
                }
            }
        }
        
    }

    // When object is clicked on, check which star,
    // activate its' effect, and destory it
    private void OnMouseDown()
    {
        IdentifyStar(starIdentifier);
        Destroy(gameObject);
    }

    /*
     * IdentifyStar
     * FUNCTION
     * Checks which star has been touched 
     * and applies effects accordingly
     */
    void IdentifyStar(int identifier)
    {
        // switch statement that effcets score
        // based on type of star
        switch (identifier)
        {
            case 1: // normal star
                MySceneManager.Instance.score+=1f * MySceneManager.Instance.multiplier;
                MySceneManager.Instance.multiplier += .05f;
                MySceneManager.Instance.stars++;
                break;
            case 2: // bad star
                MySceneManager.Instance.score-=1f;
                MySceneManager.Instance.multiplier -= .1f;
                break;
        }

        // rounds score and multiplier to nearest 100ths place
        float score = (MySceneManager.Instance.score * 100f);
        score = Mathf.Ceil(score);
        MySceneManager.Instance.score = score / 100f;

        float multiplier = (MySceneManager.Instance.multiplier * 100f);
        multiplier = Mathf.Ceil(multiplier);
        MySceneManager.Instance.multiplier = multiplier / 100f;
    }
}