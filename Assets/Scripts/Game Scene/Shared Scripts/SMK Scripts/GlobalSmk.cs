using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalSmk : MonoBehaviour
{
    // Set active class for game objects and buttons
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int CurrentCash;
    public static int smkValue = 3000;
    public static bool turnOffButton = false;
    public GameObject smkStats;
    public static int numberOfSmks;
    public static int smkPerSec;


    //  Set the text to buy a bee to the current bee value
    void Update()
    {
        CurrentCash = GlobalCash.CashCount;
        smkStats.GetComponent<Text>().text = "Smks : " + numberOfSmks + " @ " + smkPerSec + " Per Second ";
        fakeText.GetComponent<Text>().text = "Buy Smk - £" + smkValue;
        realText.GetComponent<Text>().text = "Buy Smk - £" + smkValue;

        // If cash is >= bee value hide the fake button and make the real button appear
        if (CurrentCash >= smkValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }

        // revert changes when the player does not have enough cash for the new bee value
        if (turnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        } 
    }
}
