using UnityEngine;
using UnityEngine.UI;

public class QuestionNavigation : MonoBehaviour
{
    public GameObject currentQuestion;
    public GameObject nextQuestion;

    public void GoToNextQuestion()
    {
        currentQuestion.SetActive(false);
        nextQuestion.SetActive(true);
    }
}