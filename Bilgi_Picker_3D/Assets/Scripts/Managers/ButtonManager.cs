using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonManager : MonoBehaviour
{
    public TextMeshProUGUI ClicksTotalText;

    int TotalClicks;

    public void AddClicks()
    {
        TotalClicks++;
        ClicksTotalText.text = "Points: " + TotalClicks.ToString("0");
    }
}
