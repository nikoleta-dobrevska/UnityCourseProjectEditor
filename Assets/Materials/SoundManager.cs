using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;
    private float musicVolume = 1f;

    void Start()
    {
        
    }

   public void ChangeVolume()
   {
        audioSource.volume = musicVolume;
   }

    public void UpdateVolume(float volume)
    {
        musicVolume = volume;
    }
}
