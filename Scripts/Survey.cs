using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.PlayerLoop;
using TMPro;

public class Survey : MonoBehaviour
{
    [SerializeField] InputField feedback1;
    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSfu0LPDF9Ij1E0pcwROs0xufi6d7ighhawr3op5yPHippqSuw/formResponse";
    
    public void Send(){
        StartCoroutine(Post(feedback1.text));
    }

    IEnumerator Post(string s1){
        WWWForm form = new WWWForm();
        form.AddField("entry.1561788168",s1);
        //entry.1561788168

        UnityWebRequest www = UnityWebRequest.Post(URL,form);
        yield return www.SendWebRequest();
    }
    
}



// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// using UnityEngine.Networking;

// public class Survey : MonoBehaviour
// {
//     public GameObject InputField;
//     [SerializeField] private InputField feedback1; // Use private for encapsulation
//     private string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSfu0LPDF9Ij1E0pcwROs0xufi6d7ighhawr3op5yPHippqSuw/formResponse";

//     public void Send()
//     {
//         if (feedback1.text.Length > 0) // Check if feedback is entered before sending
//         {
//             StartCoroutine(Post(feedback1.text));
//         }
//         else
//         {
//             // Display user-friendly message if no feedback is entered (optional)
//             Debug.LogWarning("Please enter your feedback before submitting.");
//         }
//     }

//     IEnumerator Post(string feedback)
//     {
//         WWWForm form = new WWWForm();
//         form.AddField("entry.1561788168", feedback); // Replace with correct field ID

//         UnityWebRequest www = UnityWebRequest.Post(URL, form);
//         yield return www.SendWebRequest();

//         if (www.isNetworkError || www.isHttpError)
//         {
//             Debug.LogError("Error submitting feedback: " + www.error);
//             // Display user-friendly error message (optional)
//         }
//         else
//         {
//             Debug.Log("Feedback submitted successfully!");
//             // Display user-friendly success message (optional)
//             // Optionally, clear the feedback field or redirect
//         }
//     }
// }
