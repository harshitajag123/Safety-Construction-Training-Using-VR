using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionManager3 : MonoBehaviour
{
    public TextMeshProUGUI  questionText;
    
    public TextMeshProUGUI   scoreText;
    public Text FinalScore;
    public Button[] replyButtons;
    public QtsData3 qtsData;//reference to the scriptable object
    public GameObject Right;
    public GameObject Wrong;
    public GameObject GameFinished;

    //currentQuest varialble to keep track of the index of the current ques
    private int currentQuestion = 0;
    //add score to store the players score
    private static int score = 0;
    
    
    // Start is called before the first frame update
    void Start()
    {
        // Get a reference to the Text component of the connected GameObject
        //questionText = GetComponent<Text>();
        //SetQuestion method will be called with the initial question index.
        SetQuestion(currentQuestion);
        
        //setting right, wrong and gamefinished panels to inactive 
        Right.gameObject.SetActive(false);
        Wrong.gameObject.SetActive(false);
        GameFinished.gameObject.SetActive(false);   
    }

    void SetQuestion(int questionIndex)
    {
        Debug.Log(qtsData);
        // Get a reference to the Text component of the connected GameObject
        //questionText = GetComponent<TextMeshProUGUI>();

        questionText.text = qtsData.questions[questionIndex]. questionText;

        //remove previous listeners before adding new ones
        foreach(Button r in replyButtons){
            r.onClick.RemoveAllListeners();
        }
        for(int i = 0; i<replyButtons.Length; i++){
            replyButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = qtsData.questions[questionIndex].replies[i];
            int replyIndex = i;
            replyButtons[i].onClick.AddListener(()=>
            {
                CheckReply(replyIndex);
            });
        }

    }

    /*create checkReply method to check if the selected reply
     is correct . if so increament score and update score text 
     and enable the "right" panel */

    void CheckReply(int replyIndex)
    {
        if(replyIndex == qtsData.questions[currentQuestion].correctReplyIndex)
        {
            score++;
            scoreText.text = "" + score;

            //Enable Right reply panel
            Right.gameObject.SetActive(true);

            //set Active false all reply buttons
            foreach (Button r in replyButtons)
            {
                r.interactable = false;
            }

            //next Question
            StartCoroutine(Next());
        }
        else
        {
            //Wrong reply
            Wrong.gameObject.SetActive(true);

            //Set Active false all reply buttons
            foreach(Button r in replyButtons){
                r.interactable = false;
            }

            //next Question
            StartCoroutine(Next());

        }

    }

    IEnumerator Next(){
        yield return new WaitForSeconds(2);
        currentQuestion++;
        if(currentQuestion < qtsData.questions.Length){
            //reset the UI and enable all reply buttons
            Reset();
        }

        else{
            //GameOver
            //if question lenght is reached the game finished panel will be set active and display the Score result
            GameFinished.SetActive(true);

            //Calculate the score percentage
            float scorePercentage = (float)score / qtsData.questions.Length * 100;

            //Display the score percentage 
            FinalScore.text = "You scored " + scorePercentage.ToString("F0") + "%";

            //Display the appropriate message based on the score percentage
            if(scorePercentage < 50 ){
                FinalScore.text += "\nGame Over";
            }
            else if (scorePercentage < 60){
                FinalScore.text += "\nKeep Trying";
            }
            else if (scorePercentage < 70){
                FinalScore.text += "\nGood Job";
            }
            else if (scorePercentage < 80){
                FinalScore.text += "\nWell Done!";
            }
            else{
                FinalScore.text += "\nYou are Excellent!";
            }
        }
    }

    public void Reset(){
         
        // Hide both the "Well done" and " Wrong" panel
        Right.SetActive(false);
        Wrong.SetActive(false);

        //enable all reply buttons
        foreach(Button r in replyButtons){
            r.interactable = true;
        }

        //Set the next question
        SetQuestion(currentQuestion);

    }

    
}
