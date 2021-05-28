using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalHoney : MonoBehaviour
{

    // Create variable to remember how many honey you have
    public static int HoneyCount;
    public GameObject HoneyDisplay;
    public int InternalHoney;

    // Display text in game showing the players honey count
    void Update()
    {
        InternalHoney = HoneyCount;
        HoneyDisplay.GetComponent<Text>().text = "Honey: " + InternalHoney;
    }
}
