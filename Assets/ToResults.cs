using UnityEngine;
using UnityEngine.SceneManagement;

public class ToResults : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Button clicked, loading PlanetOne");
        SceneManager.LoadScene("Results");
    }
}
