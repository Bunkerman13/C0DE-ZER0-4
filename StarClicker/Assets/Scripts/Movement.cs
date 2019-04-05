using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    private float mySpeed;
    void Start()
    {
        mySpeed = Random.Range(2.0f, 25.0f);
    }

    // Update is called once per frame
    void Update()
    {
        // moves stars across the screen as long as it's not paused
        if(!MySceneManager.Instance.paused)
            transform.Translate(Vector3.left * mySpeed * Time.deltaTime);

        if(gameObject.transform.position.x < -(Camera.main.orthographicSize * Camera.main.aspect) - 4f)
        {
            Destroy(gameObject);
        }
    }

    
}
