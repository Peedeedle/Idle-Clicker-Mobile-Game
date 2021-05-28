using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellHoney : MonoBehaviour
{
    // Refernces to text boxes
    public GameObject textBox;
    public GameObject StatusBox;
    //public AudioSource "";
    //public AudioSource "";
    //public int generateTone;

    
    // Create function for clicking the button and display a text box
    public void ClickTheButton ()
    {
        // Play sound in a range of the list of sounds randomly
        //generateTone = Random.Range(1, 3);

        // If Honey count = 0 display "Not enough honey and play animation
        if (GlobalHoney.HoneyCount == 0)
        {
            StatusBox.GetComponent<Text>().text = "Not enough honey to sell.";
            StatusBox.GetComponent<Animation>().Play("StatusAnim");
        } 

        else
        { 
            //
            //if(generateTone == 1)
            //{
            //    "".Play();
            //}
            //if (generateTone == 2)
            //{
            //    "".Play();
            //}

            // When making a honey + 1 to honey, when selling honey -1 to honey and +1 to cash
            GlobalHoney.HoneyCount -= 1;
            GlobalCash.CashCount += 1;
        }
        
    }

}
