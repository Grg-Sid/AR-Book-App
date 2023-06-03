using UnityEngine;
using UnityEngine.SceneManagement;
public class DoNotDestroyAudio : MonoBehaviour
{
    private static DoNotDestroyAudio backgroundMusic;

    private int sceneIndex;

    private void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
    private void Awake()
    {
        if(backgroundMusic != null)
        {
            Destroy(gameObject); 
        }
        else
        {
            backgroundMusic = this;
            DontDestroyOnLoad(gameObject);

            SceneManager.sceneLoaded += OnSceneLoaded;
        }
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if(scene.buildIndex == 2)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
