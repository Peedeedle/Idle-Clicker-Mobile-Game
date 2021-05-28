using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBee2 : MonoBehaviour
{
    // Set active class for game objects and buttons
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int CurrentCash;
    public static int bee2Value = 1000;
    public static bool turnOffButton = false;
    public GameObject bee2Stats;
    public static int numberOfBee2s;
    public static int bee2PerSec;


    //  Set the text to buy a baker to the current baker value
    void Update()
    {
        CurrentCash = GlobalCash.CashCount;
        bee2Stats.GetComponent<Text>().text = "Bee2s : " + numberOfBee2s + " @ " + bee2PerSec + " Per Second ";
        fakeText.GetComponent<Text>().text = "Buy Bee2 - £" + bee2Value;
        realText.GetComponent<Text>().text = "Buy Bee2 - £" + bee2Value;

        // If cash is >= baker value hide the fake button and make the real button appear
        if (CurrentCash >= bee2Value)
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
