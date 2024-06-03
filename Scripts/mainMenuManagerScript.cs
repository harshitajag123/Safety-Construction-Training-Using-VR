using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class mainMenuManagerScript : MonoBehaviour
{
    // public Text Passage;
    // public Button module1Button;
    // public Button module2Button;
    // public Button module3Button;

    // Start is called before the first frame update
    // void Start()
    // {
    //     module1Button = transform.Find("module1Button").GetComponent<Button>();
    //     module1Button.onClick.AddListener(Module1ButtonClicked);
    //     module2Button = transform.Find("module2Button").GetComponent<Button>();
    //     module3Button = transform.Find("module3Button").GetComponent<Button>();
        
    // }

    public void Module1ButtonClicked(string sceneName){
    // Load Module 1 interface (see next step)
    SceneManager.LoadScene(sceneName); 
    Debug.Log("Button clicked!");
    }

    public void Module2ButtonClicked(string sceneName){
    // Implement Module 2 logic here
    SceneManager.LoadScene(sceneName); 
    Debug.Log("Button clicked!");
    }


    public void Module3ButtonClicked(string sceneName){
     // Implement Module 3 logic here
    SceneManager.LoadScene(sceneName); 
    Debug.Log("Button clicked!");

    }


   
}
