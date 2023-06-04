using UnityEngine;
using UnityEngine.UI;
public class MusicPlayerScript : MonoBehaviour
{
    private AudioSource audioSource;

    public Slider volumeSlider;

    private float musicVolume = 1f;
    void Start()
    {
        Debug.Log("player");
        GameObject targetObject = GameObject.FindGameObjectWithTag("GameMusic");

        if(targetObject != null)
        {
            Debug.Log(targetObject.name);
            audioSource = targetObject.GetComponent<AudioSource>();
            if (audioSource != null)
            {
                musicVolume = PlayerPrefs.GetFloat("volume");
                audioSource.volume = musicVolume;
                volumeSlider.value = musicVolume;
            }
        }            
    }

    void Update()
    {
        audioSource.volume = musicVolume;
        PlayerPrefs.SetFloat("volume", musicVolume);
    }

    public void VolumeUpdate(float volume)
    {
        musicVolume = volume;   
    }
}
