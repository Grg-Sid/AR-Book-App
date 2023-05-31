using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void SceneLoader(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("Scene changed");
    }

    public void QuitApp()
    {
        Application.Quit();
        Debug.Log("App has quit");
    }

}
