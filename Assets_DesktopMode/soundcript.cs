using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundcript : MonoBehaviour
{   AudioSource mySource;
    private int check=0;
    // Start is called before the first frame update
    void Start()
    {
     mySource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (check==0){
          mySource.Play();
          check++;
        }
    }
}
