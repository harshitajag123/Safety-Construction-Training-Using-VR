using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class module1SceneManagerScript : MonoBehaviour
{
      public void GetEquipementButtonClicked(string sceneName){
    // Load GetEquipement interface (see next step)
    SceneManager.LoadScene(sceneName); 
    Debug.Log("Button clicked!");
    }

    public void SafetyProtocolsButtonClicked(string sceneName){
    // Load SafetyProtocols interface 
    SceneManager.LoadScene(sceneName); 
    Debug.Log("Button clicked!");
    }

    public void QuizButtonClicked(string sceneName){
      // Load QuizButton interface 
    SceneManager.LoadScene(sceneName); 
    Debug.Log("Button clicked!");
    }

    public void backButtonClicked(string sceneName){
      // Load back button interface 
    SceneManager.LoadScene(sceneName); 
    Debug.Log("Button clicked!");


    }
    
}
