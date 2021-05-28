using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBee1 : MonoBehaviour
{
    // Set active class for game objects and buttons
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int CurrentCash;
    public static int bee1Value = 100;
    public static bool turnOffButton = false;
    public GameObject bee1Stats;
    public static int numberOfBee1s;
    public static int bee1PerSec;


    //  Set the text to buy a baker to the current baker value
    void Update()
    {
        CurrentCash = GlobalCash.CashCount;
        bee1Stats.GetComponent<Text>().text = "Bee1s : " + numberOfBee1s + " @ " + bee1PerSec + " Per Second ";
        fakeText.GetComponent<Text>().text = "Buy Bee1 - £" + bee1Value;
        realText.GetComponent<Text>().text = "Buy Bee1 - £" + bee1Value;

        // If cash is >= baker value hide the fake button and make the real button appear
        if (CurrentCash >= bee1Value)
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
