using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleStore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickEnter()
    {
        MySceneManager.Instance.paused = !MySceneManager.Instance.paused;
        MySceneManager.Instance.storeCanvas.GetComponent<Canvas>().sortingOrder = 2;

        Image storeBackground = GameObject.Find("StoreBackground").GetComponent<Image>();

        // makes image solid
        Color tempColor = storeBackground.color;
        tempColor.a = 1f;
        storeBackground.color = tempColor;

        // toggles raycast target (allow it to be clicked or not)
        storeBackground.raycastTarget = !storeBackground.raycastTarget;
    }

    public void ClickExit()
    {
        MySceneManager.Instance.paused = !MySceneManager.Instance.paused;
        MySceneManager.Instance.storeCanvas.GetComponent<Canvas>().sortingOrder = -2;

        Image storeBackground = GameObject.Find("StoreBackground").GetComponent<Image>();

        // makes image transparent
        Color tempColor = storeBackground.color;
        tempColor.a = 0f;
        storeBackground.color = tempColor;

        // toggles raycast target (allow it to be clicked or not)
        storeBackground.raycastTarget = !storeBackground.raycastTarget;
    }
}
