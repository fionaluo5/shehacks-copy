using UnityEngine;
using UnityEngine.SceneManagement;

public class ToPlanetFour : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Button clicked, loading PlanetOne");
        SceneManager.LoadScene("PlanetFour");
    }
}
