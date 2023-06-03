using UnityEngine;
using UnityEngine.UI;
public class MusicPlayerScript : MonoBehaviour
{
    public AudioSource AudioSource;

    public Slider volumeSlider;

    private float musicVolume = 1f;
    void Start()
    {
        AudioSource.Play();
        musicVolume = PlayerPrefs.GetFloat("volume");
        AudioSource.volume = musicVolume;
        volumeSlider.value = musicVolume;
    }

    void Update()
    {
        AudioSource.volume = musicVolume;
        PlayerPrefs.SetFloat("volume", musicVolume);
    }

    public void VolumeUpdate(float volume)
    {
        musicVolume = volume;   
    }
}
