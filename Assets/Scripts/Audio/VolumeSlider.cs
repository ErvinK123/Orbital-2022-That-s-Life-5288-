using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    /*
    public AudioMixer audioMixer;

    public void setVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
    */

    [SerializeField] Slider volumeSlider;

    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            // Set volume to 100% by default
            PlayerPrefs.SetFloat("musicVolume", 1);
            load();
        } else
        {
            load();
        }
    } 

    public void changeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        save();
    }

    public void load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    public void save()
    {
        // Saving the volume the user has set
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
}
