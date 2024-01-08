using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManagerScript : MonoBehaviour
{
    private AudioSource audioSource;
    private float musicVolume = 0f;

    public Slider volumeSlider;
    public GameObject music;

    void Start()
    {
        music = GameObject.FindWithTag("GameMusic");
        audioSource = music.GetComponent<AudioSource>();

        musicVolume = PlayerPrefs.GetFloat("volume");
        audioSource.volume = musicVolume;
        volumeSlider.value = musicVolume;
    }

    private void Update()
    {
        audioSource.volume = musicVolume;
        PlayerPrefs.SetFloat("volume", musicVolume);
    }

    public void UpdateVolume(float volume)
    {
        musicVolume = volume;
    }
}
