using UnityEngine;
using UnityEngine.SceneManagement;

public class PlanetTwo : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Button clicked, loading PlanetOne");
        SceneManager.LoadScene("PlanetTwo");
    }
}
