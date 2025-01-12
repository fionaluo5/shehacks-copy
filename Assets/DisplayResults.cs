using UnityEngine;
using UnityEngine.SceneManagement;

public class DisplayResults : MonoBehaviour
{
    // Call this method to load the Results scene
    public void ShowResults()
    {
        Debug.Log("Displaying Results...");
        SceneManager.LoadScene("Results");
    }
}