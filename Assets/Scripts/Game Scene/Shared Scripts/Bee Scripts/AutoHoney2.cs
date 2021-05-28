using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoHoney2 : MonoBehaviour
{
    // Public classes for create an automatic honey generation
    public bool CreatingHoney = false;
    public static int HoneyIncrease = 2;
    public int InternalIncrease;


    // If purchased automatic honey create the honey 1 per second using "CreateThehoney" if not do nothing
    void Update()
    {
        HoneyIncrease = GlobalBee2.bee2PerSec;
        InternalIncrease = HoneyIncrease;
        if (CreatingHoney == false)
        {
            CreatingHoney = true;
            StartCoroutine(CreateTheHoney2());
        }
    }

    // Create honey per second = 2
    IEnumerator CreateTheHoney2 ()
    {
        GlobalHoney.HoneyCount += InternalIncrease;
        yield return new WaitForSeconds(2);
        CreatingHoney = false;

    }


}
