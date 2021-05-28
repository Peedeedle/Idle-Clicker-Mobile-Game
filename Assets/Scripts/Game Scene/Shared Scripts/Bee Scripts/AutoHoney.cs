using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoHoney : MonoBehaviour
{
    // Public classes for create an automatic honey generation
    public bool CreatingHoney = false;
    public static int HoneyIncrease = 1;
    public int InternalIncrease;


    // If purchased automatic honey create the honey 1 per second using "CreateThehoney" if not do nothing
    void Update()
    {
        HoneyIncrease = GlobalBee1.bee1PerSec;
        InternalIncrease = HoneyIncrease;
        if (CreatingHoney == false)
        {
            CreatingHoney = true;
            StartCoroutine(CreateTheHoney());
        }

    }

    // Create honey per second = 1
    IEnumerator CreateTheHoney ()
    {
        GlobalHoney.HoneyCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingHoney = false;

    }


}
