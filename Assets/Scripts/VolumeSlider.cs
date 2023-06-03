using UnityEngine;

public class VolumeSlider : MonoBehaviour
{
    public GameObject Target;
    
    public void SetVolume(float volume)
    {
        Target.GetComponent<AudioSource>().volume = volume;
    }

}
