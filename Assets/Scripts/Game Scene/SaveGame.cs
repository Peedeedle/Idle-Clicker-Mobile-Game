using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    public class SaveGame : MonoBehaviour
    {
        // reference global cash script
        public int saveGameCash;
        public static int saveValue = 1;
        public GameObject saveButton;
        public GameObject saveText;


        // If the player has enough cash display the save button 
        void Update()
        {
        
            saveText.GetComponent<Text>().text = "cost: £" + saveValue;
            
            
            saveGameCash = GlobalCash.CashCount;
            if (saveGameCash >= saveValue)
            {
                saveButton.GetComponent<Button>().interactable = true;
            }
            else
            {
                saveButton.GetComponent<Button>().interactable = false;
            }

        }

        // Save the game and the player preferences
        public void SaveTheGame()
        {
            GlobalCash.CashCount -= saveValue;
            PlayerPrefs.SetInt("SavedHoney", GlobalHoney.HoneyCount);
            PlayerPrefs.SetInt("SavedCash", GlobalCash.CashCount);
            PlayerPrefs.SetInt("SavedBee1s", GlobalBee1.bee1PerSec);
            PlayerPrefs.SetInt("SavedBee2s", GlobalBee2.bee2PerSec);
            PlayerPrefs.SetInt("SavedBee3s", GlobalBee3.bee3PerSec);
            PlayerPrefs.SetInt("SavedShops", GlobalShop.numberOfShops);
            saveValue = 1;
            PlayerPrefs.SetInt("SavedValue", saveValue);

        }

    }
