using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    // References to game objects and audio source
    public GameObject AutoHoney;
    public GameObject AutoSell;
    public AudioSource playSound;

    // "upgrade" to start auto honey generation set to true
    public void StartAutoHoney()
    {
        playSound.Play();
        // Every time a bee is bought double the amount last needed to buy a bee then turn off the real button
        AutoHoney.SetActive(true);
        GlobalCash.CashCount -= GlobalBee1.bee1Value;
        GlobalBee1.bee1Value *= 2;
        GlobalBee1.turnOffButton = true;
        GlobalBee1.bee1PerSec += 1;
        GlobalBee1.numberOfBee1s += 1;
    }

    // Start auto aquiring Bee 2's honey
    public void StartAutoHoney2()
    {
        playSound.Play();
        // Every time a bee is bought double the amount last needed to buy a bee then turn off the real button
        AutoHoney.SetActive(true);
        GlobalCash.CashCount -= GlobalBee2.bee2Value;
        GlobalBee2.bee2Value *= 2;
        GlobalBee2.turnOffButton = true;
        GlobalBee2.bee2PerSec += 2;
        GlobalBee2.numberOfBee2s += 1;
    }

    // Start auto selling Shops honey
    public void StartAutoSell()
    {
        playSound.Play();
        // Every time a bee is bought double the amount last needed to buy a bee then turn off the real button
        AutoSell.SetActive(true);
        GlobalCash.CashCount -= GlobalShop.shopValue;
        GlobalShop.shopValue *= 2;
        GlobalShop.turnOffButton = true;
        GlobalShop.shopPerSec += 1;
        GlobalShop.numberOfShops += 1;
    }

    // Start auto selling Supermarkets honey
    public void StartAutoSell2()
    {
        playSound.Play();
        // Every time a bee is bought double the amount last needed to buy a bee then turn off the real button
        AutoSell.SetActive(true);
        GlobalCash.CashCount -= GlobalSmk.smkValue;
        GlobalSmk.smkValue *= 2;
        GlobalSmk.turnOffButton = true;
        GlobalSmk.smkPerSec += 5;
        GlobalSmk.numberOfSmks += 1;
    }

    // Start aquiring Bee 3's honey
    public void StartAutoHoney3()
    {
        playSound.Play();
        // Every time a bee is bought double the amount last needed to buy a bee then turn off the real button
        AutoHoney.SetActive(true);
        GlobalCash.CashCount -= GlobalBee3.bee3Value;
        GlobalBee3.bee3Value *= 2;
        GlobalBee3.turnOffButton = true;
        GlobalBee3.bee3PerSec += 5;
        GlobalBee3.numberOfBee3s += 1;
    }

    // Start auto selling Supermarkets honey
    public void StartAutoSell3()
    {
        playSound.Play();
        // Every time a bee is bought double the amount last needed to buy a bee then turn off the real button
        AutoSell.SetActive(true);
        GlobalCash.CashCount -= GlobalSmk.smkValue;
        GlobalSmk.smkValue *= 2;
        GlobalSmk.turnOffButton = true;
        GlobalSmk.smkPerSec += 5;
        GlobalSmk.numberOfSmks += 1;
    }

}



