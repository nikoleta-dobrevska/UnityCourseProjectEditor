using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGraphicsQuality : MonoBehaviour
{
    public void SetGraphics(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }

}
