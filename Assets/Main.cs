using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{

    public void Starting() {
            DestroyPersistentObjects2();
        Debug.Log("Button clicked, loading PlanetOne");

        SceneManager.LoadScene("SampleScene");
    }

    private void DestroyPersistentObjects2()
    {
        // Find all root objects in the scene
        GameObject[] rootObjects = GameObject.FindObjectsOfType<GameObject>();

        foreach (GameObject obj in rootObjects)
        {
            // Check if the object is persistent
            if (obj.scene.name == null || obj.scene.name == "")
            {
                Debug.Log("Destroying persistent object: " + obj.name);
                Destroy(obj);
            }
        }
    }
}
