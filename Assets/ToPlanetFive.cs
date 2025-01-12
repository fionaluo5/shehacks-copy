using UnityEngine;
using UnityEngine.SceneManagement;

public class ToPlanetFive : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Button clicked, loading PlanetOne");
        SceneManager.LoadScene("PlanetFive");
    }
}
