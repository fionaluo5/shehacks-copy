using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Button clicked, loading PlanetOne");
        SceneManager.LoadScene("PlanetOne");
    }
}
