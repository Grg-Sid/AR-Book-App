using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int sceneIndex;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log(SceneManager.GetActiveScene().buildIndex);
            GoBack(); 
        }
    }
    public void GoBack()
    {
        SceneManager.LoadScene(sceneIndex);
    }

}
