using System;
using TMPro;
using UnityEngine;

public class StickCounter : MonoBehaviour
{
    public TextMeshProUGUI stickText; // Referenz auf den Text

    private int stickCount = 0;

    public void AddStick()
    {
        stickCount++;
        stickText.text = "Stämme: " + stickCount;
        Debug.Log("stix:" + stickCount);
    }
}
