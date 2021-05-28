using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisasterScript : MonoBehaviour
{
    //set disaster to false as we do not want negative numbers at the start of the game
    public GameObject statusBox;
    public float honeyCheck;
    public int genChance;
    public bool disasterActive = false;
    public int honeyLoss;

    // Check to see the number of honey the player has and if it is a certain amount then start disaster enumerator
    void Update()
    {
        honeyCheck = GlobalHoney.HoneyCount / 100;
        if (disasterActive == false)
        {
            StartCoroutine(StartDisaster());
        }
    }

    // IEnumerator disaster script
    IEnumerator StartDisaster()
    {
        // When referenced the disaster script becomes active and generates a random chance from 1-20 by the amount of honey the player has
        disasterActive = true;
        genChance = Random.Range(1, 200);
        if (honeyCheck >= genChance)
        {
            // take 25% of the players honey and display a message in game making the text wait for 3 seconds allowing the player to see it and play the animation for the text to fade
            honeyLoss = Mathf.RoundToInt(GlobalHoney.HoneyCount * 2);
            statusBox.GetComponent<Text>().text = "You lost " + honeyLoss + " Honey in a factory fire";
            GlobalHoney.HoneyCount -= honeyLoss;
            yield return new WaitForSeconds(3);
            statusBox.GetComponent<Animation>().Play("StatusAnim");
            yield return new WaitForSeconds(1);
            statusBox.SetActive(false);
            statusBox.SetActive(true);

        }

        // Wait 10 seconds then set the disaster to false and repeat
        yield return new WaitForSeconds(10);
        disasterActive = false;
    }
}
