using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuButtons : MonoBehaviour
{
   

    public void StartNewGame()
    {
        SceneManager.LoadScene(4);
    }

    public void SettingsMenu()
    {
        SceneManager.LoadScene(1);
    }

    /*public void CreditsScene()
    {
        SceneManager.LoadScene(5);
    }*/

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
Application.Quit();
#endif
    }
}
