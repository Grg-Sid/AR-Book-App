using UnityEngine;
public class ClickObject : MonoBehaviour
{
    public GameObject VolumeSlider;

    public void ButtonClicked()
    {
        switch (VolumeSlider.activeInHierarchy)
        {
            case true:
                VolumeSlider.SetActive(false);
                break;
            default:
                VolumeSlider.SetActive(true);
                break;
        }
    }
}
