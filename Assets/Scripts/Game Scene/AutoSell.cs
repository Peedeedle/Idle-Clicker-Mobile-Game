using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour
{
    

    // Public classes for create an automatic honey generation
    public bool SellingHoney = false;
    public static int CashIncrease = 1;
    public int InternalIncrease;


    // If purchased automatic honey create the honey 1 per second using "CreateTheHoney" if not do nothing
    void Update()
    {
        CashIncrease = GlobalShop.shopPerSec;
        InternalIncrease = CashIncrease;
        if (SellingHoney == false)
        {
            SellingHoney = true;
            StartCoroutine(SellTheHoney());
        }
    }

    // Create honey per second = 1
    IEnumerator SellTheHoney ()
    {
        if (GlobalHoney.HoneyCount == 0)
        {

        }
        else
        {
            GlobalCash.CashCount += InternalIncrease;
            GlobalHoney.HoneyCount -= 1;
            yield return new WaitForSeconds(1);
            SellingHoney = false;
        }

        


        
    }
}
