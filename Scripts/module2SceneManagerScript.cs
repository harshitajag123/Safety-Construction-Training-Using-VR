using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class module2SceneManagerScript : MonoBehaviour
{
    public void ImageButtonClicked(string sceneName){
    // Load Image interface (see next step)
    SceneManager.LoadScene(sceneName); 
    Debug.Log("Button clicked!");
    }

    public void SampleVideosButtonClicked(string sceneName){
    // Loadsample videos interface logic here
    SceneManager.LoadScene(sceneName); 
    Debug.Log("Button clicked!");
    }

    public void GearInfoButtonClicked(string sceneName){
     // Load Gear info interface 
    SceneManager.LoadScene(sceneName); 
    Debug.Log("Button clicked!");
    }

    public void backButtonClicked(string sceneName){
     // Load back button interface 
    SceneManager.LoadScene(sceneName); 
    Debug.Log("Button clicked!");
    }

}

