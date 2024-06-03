using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backButtonManagerScript : MonoBehaviour
{
     public void BackButtonClicked(string sceneName){
    // Load back button interface (see next step)
    SceneManager.LoadScene(sceneName); 
    Debug.Log("Button clicked!");
    }

  
    
}
