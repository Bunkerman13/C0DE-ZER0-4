using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelGauge : MonoBehaviour
{

    public Transform bar;
    // Start is called before the first frame update
    void Start()
    {
        bar = transform.Find("Bar");
        
    }

    public void SetSize(float sizeNormalized)
    {
        bar.localScale = new Vector3(sizeNormalized, 0.5f);
    }
}
