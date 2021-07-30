using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1mov : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)){
        transform.Translate(-(float)0.1,0,0);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
        transform.Translate((float)0.1,0,0);
        }
        if(Input.GetKey(KeyCode.UpArrow)){
        transform.Translate(0,0,(float)0.1);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
        transform.Translate(0,0,-(float)0.1);
        }
 
    }
}
