using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalShop : MonoBehaviour
{
    // Set active class for game objects and buttons
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int CurrentCash;
    public static int shopValue = 500;
    public static bool turnOffButton = false;
    public GameObject shopStats;
    public static int numberOfShops;
    public static int shopPerSec;


    //  Set the text to buy a bee to the current bee value
    void Update()
    {
        CurrentCash = GlobalCash.CashCount;
        shopStats.GetComponent<Text>().text = "Shops : " + numberOfShops + " @ " + shopPerSec + " Per Second ";
        fakeText.GetComponent<Text>().text = "Buy Shop - £" + shopValue;
        realText.GetComponent<Text>().text = "Buy Shop - £" + shopValue;

        // If cash is >= bee value hide the fake button and make the real button appear
        if (CurrentCash >= shopValue)
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
