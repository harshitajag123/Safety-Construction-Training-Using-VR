using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sampleVideosSceneManagerScript : MonoBehaviour
{
    public void IntroButtonClicked(string sceneName){
    // Load Intro video interface (see next step)
    SceneManager.LoadScene(sceneName); 
    Debug.Log("Button clicked!");
    }

    public void PartsAndFunctionsButtonClicked(string sceneName){
    // Implement parts and function video logic here
    SceneManager.LoadScene(sceneName); 
    Debug.Log("Button clicked!");
    }

    public void safetyPrecautionsButtonClicked(string sceneName){
    //load safetyPrecautions video
    SceneManager.LoadScene(sceneName); 
    Debug.Log("Button clicked!");
    }

    public void commonbackButtonClicked(string sceneName){
    //load back button scene
    SceneManager.LoadScene(sceneName); 
    Debug.Log("Button clicked!");
    }

}

