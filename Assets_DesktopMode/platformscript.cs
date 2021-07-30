using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformscript : MonoBehaviour
{
    // Start is called before the first frame update
    private float increase=0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   increase+=0.001f;
        transform.Rotate(0,(float)0.25+increase,0);
    }
}
