using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class initialscript : MonoBehaviour
{   
    private float timeelapsed=1f;
    private string sceneNameToLoad="description";
    void start(){}
    void Update()
    {
      timeelapsed+=Time.deltaTime;
      if (timeelapsed>5f){
         SceneManager.LoadScene(sceneNameToLoad);
      }        
    }
}
