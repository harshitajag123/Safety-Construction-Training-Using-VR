// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New QuestionData", menuName = "QuestionData3")]

public class QtsData3 : ScriptableObject
{
    [System.Serializable]
    public struct Question
    {
        //store questions
        public string questionText;
        //store replies
        public string[] replies;
        //store correct reply index
        public int correctReplyIndex;
    }

    //Qustion[]array will hold a collection of questions and thier associated data
    public Question[] questions;
    
}
