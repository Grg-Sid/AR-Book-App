using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    int sceneIndex, currentIndex; 
    private void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        currentIndex = sceneIndex;
        //Time.fixedDeltaTime = 1/2;
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Debug.Log("Esc was pressed");
            if (currentIndex == 0)
            {
                Application.Quit();
                Debug.Log("App has Quit");
            }
            else
            {
                SceneManager.LoadScene(sceneIndex - 1);
                currentIndex = sceneIndex - 1;
                Debug.Log("Scene Changed");
            }
        }
        if (!Input.GetKeyDown(KeyCode.Escape))
        {
            return;
        }
    }

    public void SceneLoaderNext()
    {
        SceneManager.LoadScene(sceneIndex + 1);
        currentIndex = sceneIndex + 1;
        Debug.Log(currentIndex);
    }
    public void SceneLoaderPrevious()
    {
        SceneManager.LoadScene(sceneIndex - 1);
        currentIndex = sceneIndex - 1;
        Debug.Log(currentIndex);
    }
    public void QuitApp()
    {
        Application.Quit();
        Debug.Log("App has quit");
    }

}
