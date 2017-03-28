// Various examples of scene management for Unity 5+
using UnityEngine;
using System.Collections;
// Needed in Unity 5+
using UnityEngine.SceneManagement;

public class SceneManagementExamples : MonoBehaviour
{
    // Name of new scene. Don't forget to add to build settings!
    public string scene;

    // Load the new scene
    public void LoadScene(string newScene)
    {
        SceneManager.LoadScene(newScene);
    }

    // Reload the current scene
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
