using UnityEngine;
using UnityEngine.UI;

public class quizManagerScript : MonoBehaviour
{
    // Text objects for questions, answers, and score (replace with your UI Text references)
    public Text questionText;
    public Text answer1Text;
    public Text answer2Text;
    public Text answer3Text;
    public Text answer4Text;
    public Text scoreText;

    // Array to store questions (question text)
    public string[] questions;

    // Array to store answer options (2D array, each inner array represents options for a question)
    public string[][] answers;

    // Array to store correct answer indices for each question
    public int[] correctAnswers;

    // Current question index
    private int currentQuestionIndex = 0;
    // Player's score
    private int score = 0;

    void Start()
    {
        // Sample questions and answers (replace with your actual content)
        questions = new string[] {
            "1. What's the hard hat for?",
            "5. When choosing gloves, what matters most?",
            "6. How do you clean safety glasses?",
            "7. What should you NOT do with your Hi-Vis vest?"
        };
        answers = new string[][] {
            new string[] { "(a) Keep head warm", "(b) Protect head from falling things (Correct)", "(c) Look cool", "(d) Block the sun" },
            new string[] { "(a) Color", "(b) Job you're doing  (Correct)", "(c) Size only", "(d) Brand" },
            new string[] { "(a) With a rag", "(b) In the dishwasher", "(c) Special cloth and cleaner  (Correct)", "(d) With your shirt" },
            new string[] { "(a) Wash it", "(b) Replace if damaged", "(c) Wear it all the time", "(d) Share it with others (Correct)" }
        };
        correctAnswers = new int[] { 1, 1, 2, 3 };

        // Display the first question
        DisplayQuestion();
    }

    public void OnAnswerButtonClicked(int buttonIndex)
    {
        // Calculate question index based on button order (assuming buttons are ordered sequentially)
        int questionIndex = buttonIndex / 4;

        // Check if the selected answer is correct
        if (buttonIndex % 4 == correctAnswers[questionIndex])
        {
            score++;
            Debug.Log("Correct!"); // Optional: Display a "Correct" message
        }
        else
        {
            Debug.Log("Incorrect. The correct answer is: " + answers[questionIndex][correctAnswers[questionIndex]]); // Optional: Display the correct answer
        }

        // Check if all questions are answered
        if (currentQuestionIndex + 1 >= questions.Length)
        {
            // Display results (optional)
            questionText.text = "Quiz Finished!";
            answer1Text.text = "";
            answer2Text.text = "";
            answer3Text.text = "";
            answer4Text.text = "";
            scoreText.text = "Your score: " + score + "/" + questions.Length;
        }
        else
        {
            currentQuestionIndex++;
            DisplayQuestion();
        }
    }

    void DisplayQuestion()
    {
        // Update text for all questions and answers
        questionText.text = "Question 1: " + questions[0] + "\n" +
                         "Question 2: " + questions[1] + "\n" +
                         "Question 3: " + questions[2] + "\n" +
                         "Question 4: " + questions[3];
        answer1Text.text = "1. " + answers[0][0] + "\n" +
                       "2. " + answers[1][0] + "\n" +
                       "3. " + answers[2][0] + "\n" +
                       "4. " + answers[3][0];
        answer2Text.text = "1. " + answers[0][1] + "\n" +
                       "2. " + answers[1][1] + "\n" +
                       "3. " + answers[2][1] + "\n" +
                       "4. " + answers[3][1];
        answer3Text.text = "1. " + answers[0][2] + "\n" +
                       "2. " + answers[1][2] + "\n" +
                       "3. " + answers[2][2] + "\n" +
                       "4. " + answers[3][2];
        answer4Text.text = "1. " + answers[0][3] + "\n" +
                       "2. " + answers[1][3]+ "\n" +
                       "3. " + answers[2][3] + "\n" +
                       "4. " + answers[3][3];

    }
}
