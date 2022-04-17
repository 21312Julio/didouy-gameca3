using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{
    [SerializeField] private string sceneName;

    // Change Scene
    public void GoTo()
    {
        SceneManager.LoadScene(sceneName);
    }

    // Close Game and Application
    public void ExitGame()
    {
        Application.Quit();
    }
}
