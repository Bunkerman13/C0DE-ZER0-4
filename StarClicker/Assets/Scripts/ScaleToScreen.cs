using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleToScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //// scales the image to screen size
        Vector2 screenConversion = Camera.main.WorldToScreenPoint(new Vector2(Camera.main.orthographicSize * Camera.main.aspect, Camera.main.orthographicSize));
        GetComponent<RectTransform>().sizeDelta = screenConversion;

        Color tempColor = GetComponentInChildren<Image>().color;

        tempColor.a = 0f;
        
        GetComponentInChildren<Image>().color = tempColor;
    }
}
