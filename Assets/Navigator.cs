using UnityEngine;

public class QuestionNavigation : MonoBehaviour
{
    public GameObject currentQuestion;  // Current question panel
    public GameObject nextQuestion;     // Next question panel
    public GameObject previousQuestion; // Previous question panel

    private bool hasClickedNext = false;  // Prevent multiple clicks for Next
    private bool hasClickedBack = false;  // Prevent multiple clicks for Back

    // Function for the NEXT button
    public void GoToNextQuestion()
    {
        if (hasClickedNext) return;

        currentQuestion.SetActive(false);
        nextQuestion.SetActive(true);

        hasClickedNext = true;
    }

    // Function for the BACK button
    public void GoToPreviousQuestion()
    {
        if (hasClickedBack) return;

        currentQuestion.SetActive(false);
        previousQuestion.SetActive(true);

        hasClickedBack = true;
    }
}