using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour
{
    // Reference to text box
    public GameObject textBox;
    
    // Create function for clicking the button and display a text box
    public void ClickTheButton ()
    {
        GlobalHoney.HoneyCount += 1;
    }

}
