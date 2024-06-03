using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. SceneManagement;

public class nextButtonManagerScript : MonoBehaviour
{
    public void NextButtonClicked(string sceneName){
    // Load next button interface (see next step)
    SceneManager.LoadScene(sceneName); 
    Debug.Log("Button clicked!");
    }

}
