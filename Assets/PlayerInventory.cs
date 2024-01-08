using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
   public int NumberOfCrystals { get; private set; }

   public UnityEvent<PlayerInventory> OnCrystalCollected;

    public AudioSource src;
    public void CrystalCollected()
    {
        src.Play();
        NumberOfCrystals++;
        OnCrystalCollected.Invoke(this);
    }
}
