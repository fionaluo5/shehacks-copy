using UnityEngine;
using UnityEngine.SceneManagement;

public class ToPlanetOne : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Button clicked, loading PlanetOne");
        SceneManager.LoadScene("PlanetOne");
    }
}
