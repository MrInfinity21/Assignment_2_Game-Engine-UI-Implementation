using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private string inGameScene;
    private string mainMenuScene; 

    public void ResumeGame()
    {
        SceneManager.LoadScene(2);
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
Application.Quit();
#endif
    }
}
