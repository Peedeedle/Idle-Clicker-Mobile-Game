using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    // public ints of the saved preferences for the load menu
    public int savedHoney;
    public int savedCash;
    public int savedBee1s;
    public int savedBee2s;
    public int savedShops;
    public int savedValue;

    // If Loaded a previous game import all the saved player preferences
    void Start()
    {
        if(MainMenuOptions.isLoading == true)
        {
            savedHoney = PlayerPrefs.GetInt("SavedHoney");
            GlobalHoney.HoneyCount = savedHoney;

            savedCash = PlayerPrefs.GetInt("SavedCash");
            GlobalCash.CashCount = savedCash;

            savedBee1s = PlayerPrefs.GetInt("SavedBee1s");
            GlobalBee1.bee1PerSec = savedBee1s;

            savedBee2s = PlayerPrefs.GetInt("SavedBee2s");
            GlobalBee2.bee2PerSec = savedBee2s;

            savedShops = PlayerPrefs.GetInt("SavedShops");
            GlobalShop.numberOfShops = savedShops;

            savedValue = PlayerPrefs.GetInt("SaveValue");
            SaveGame.saveValue = savedValue;


        }
    }

}
