using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Countdown : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI countdownText;
    [SerializeField] float remainingTime;
    public Canvas Finale;
    public TextMeshProUGUI gameOverText;
    public PlayerInventory playerInventory;
    public AudioSource timeOutSound;

    public void Update()
    {
        remainingTime -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);

        countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (remainingTime <= 1 && remainingTime >= 0)
        {
            timeOutSound.Play();
        }

        if (remainingTime < 0)
        {
            minutes = 0;
            seconds = 0;
            countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            countdownText.color = Color.red;

            GameObject[] crystals = GameObject.FindGameObjectsWithTag("Crystal");

            foreach(var crystal in crystals)
            {
               crystal.SetActive(false);
            }

            string missingCrystals = playerInventory.NumberOfCrystals.ToString();
            gameOverText.text = "You lost! Wanna try one more time?\n" + missingCrystals + " out of 3 crystals collected";

            Finale = Finale.GetComponent<Canvas>();
            Finale.gameObject.SetActive(true);
        }

        if (remainingTime >= 0 && playerInventory.NumberOfCrystals == 3)
        {
            gameOverText.text = "Congratulations, you managed to collect all the crystals! Wanna play again?";
            countdownText.text = string.Empty;
            Finale = Finale.GetComponent<Canvas>();
            Finale.gameObject.SetActive(true);
        }
    }
}
