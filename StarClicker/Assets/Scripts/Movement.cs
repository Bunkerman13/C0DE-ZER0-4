using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public MySceneManager manager;
    // Start is called before the first frame update
    private float mySpeed;
    void Start()
    {
        mySpeed = Random.Range(2.0f, 25.0f);
        manager = GameObject.FindGameObjectWithTag("OriginalSceneManager").GetComponent<MySceneManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // moves stars across the screen as long as it's not paused
        if(!manager.paused)
            transform.Translate(Vector3.left * mySpeed * Time.deltaTime);

        if(gameObject.transform.position.x < -(Camera.main.orthographicSize * Camera.main.aspect) - 4f)
        {
            Destroy(gameObject);
        }
    }

    
}
