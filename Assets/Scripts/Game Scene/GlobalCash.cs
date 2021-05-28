using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{
    // Create variable to remember how much cash the player has
    public static int CashCount;
    public GameObject CashDisplay;
    public int InternalCash;

    public GameObject textBox;
    public GameObject StatusBox;

    // Display text in game showing the players cash count
    void Update()
    {
        InternalCash = CashCount;
        CashDisplay.GetComponent<Text>().text = "£" + InternalCash;
    }

    // If the player has no money tell them they do not have enough money
    public void ClickTheButton()
    {
        if (GlobalCash.CashCount == 0)
        {
            StatusBox.GetComponent<Text>().text = "Not enough £";
            StatusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else
        {
           
        }
    }

}
