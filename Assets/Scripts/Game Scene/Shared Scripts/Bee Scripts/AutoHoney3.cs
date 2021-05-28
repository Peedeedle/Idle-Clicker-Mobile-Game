using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoHoney3 : MonoBehaviour
{
    // Public classes for create an automatic honey generation
    public bool CreatingHoney = false;
    public static int HoneyIncrease = 2;
    public int InternalIncrease;


    // If purchased automatic honey create the honey 1 per second using "CreateThehoney" if not do nothing
    void Update()
    {
        HoneyIncrease = GlobalBee3.bee3PerSec;
        InternalIncrease = HoneyIncrease;
        if (CreatingHoney == false)
        {
            CreatingHoney = true;
            StartCoroutine(CreateTheHoney3());
        }
    }

    // Create honey per second = 5
    IEnumerator CreateTheHoney3 ()
    {
        GlobalHoney.HoneyCount += InternalIncrease;
        yield return new WaitForSeconds(2);
        CreatingHoney = false;

    }


}
