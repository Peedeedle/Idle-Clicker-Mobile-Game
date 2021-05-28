using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell3 : MonoBehaviour
{
    // Public classes for create an automatic honey generation
    public bool SellingHoney = false;
    public static int CashIncrease = 5;
    public int InternalIncrease;


    // If purchased automatic honey create the honey 1 per second using "CreateTheHoney" if not do nothing
    void Update()
    {
        CashIncrease = GlobalSmk.smkPerSec;
        InternalIncrease = CashIncrease;
        if (SellingHoney == false)
        {
            SellingHoney = true;
            StartCoroutine(SellTheHoney3());
        }
    }

    // Create honey per second = 1
    IEnumerator SellTheHoney3 ()
    {
        if(GlobalHoney.HoneyCount == 0)
        {
            // We can't do anything
        }
        else
        {
            GlobalCash.CashCount += InternalIncrease;
            GlobalHoney.HoneyCount -= 5;
            yield return new WaitForSeconds(1);
            SellingHoney = false;
        }

        
    }
}
