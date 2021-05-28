using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBee3 : MonoBehaviour
{
    // Set active class for game objects and buttons
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int CurrentCash;
    public static int bee3Value = 5000;
    public static bool turnOffButton = false;
    public GameObject bee3Stats;
    public static int numberOfBee3s;
    public static int bee3PerSec;


    //  Set the text to buy a baker to the current baker value
    void Update()
    {
        CurrentCash = GlobalCash.CashCount;
        bee3Stats.GetComponent<Text>().text = "Bee3s : " + numberOfBee3s + " @ " + bee3PerSec + " Per Second ";
        fakeText.GetComponent<Text>().text = "Buy Bee3 - £" + bee3Value;
        realText.GetComponent<Text>().text = "Buy Bee3 - £" + bee3Value;

        // If cash is >= baker value hide the fake button and make the real button appear
        if (CurrentCash >= bee3Value)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }

        // revert changes when the player does not have enough cash for the new baker value
        if (turnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        } 
    }
}
