using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. SceneManagement;

public class module3SceneManagerScripts : MonoBehaviour
{
    public void StartOperatingButtonClicked(string sceneName){
    // Load Start realtime operation 1 interface (see next step)
    SceneManager.LoadScene(sceneName); 
    Debug.Log("Button clicked!");
    }

    public void QuizFeedbackButtonClicked(string sceneName){
    // Implement  Quiz 3 interface logic here
    SceneManager.LoadScene(sceneName); 
    Debug.Log("Button clicked!");
    }

    public void FeedbackButtonClicked(string sceneName){
    // Implement  Quiz 3 interface logic here
    SceneManager.LoadScene(sceneName); 
    Debug.Log("Button clicked!");
    }

    public void backButtonClicked(string sceneName){
    //load back scene 
    SceneManager.LoadScene(sceneName); 
    Debug.Log("Button clicked!");
    }
}
