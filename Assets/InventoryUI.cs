using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI crystalText;

    void Start()
    {
        crystalText= GetComponent<TextMeshProUGUI>();
    }

    public void UpdateCrystalText(PlayerInventory playerInventory)
    {
        crystalText.text = playerInventory.NumberOfCrystals.ToString();
    }
}
