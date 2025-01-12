using UnityEngine;
using UnityEngine.SceneManagement;

public class ToPlanetThree : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Button clicked, loading PlanetOne");
        SceneManager.LoadScene("PlanetThree");
    }
}
