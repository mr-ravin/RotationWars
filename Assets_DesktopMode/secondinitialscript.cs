using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class secondinitialscript : MonoBehaviour
{
    private float timeelapsed=1f;
    private string sceneNameToLoad="SampleScene";
    void start(){}
    void Update()
    {
      timeelapsed+=Time.deltaTime;
      if (timeelapsed>5f){
         SceneManager.LoadScene(sceneNameToLoad);
      }        
    }
}


