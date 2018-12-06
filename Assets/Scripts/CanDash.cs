using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanDash : MonoBehaviour
{
    public int Dashable = 0;
    public float StopDash = 0;
    public bool DashAllowed = false;
    public bool DashSlow = false;
    public bool ok = false;
    void Update()
    {
        //StopDash använder jag som en slags timer så att jag kan få vissa events hända efter en viss tid
        StopDash += Time.deltaTime;
        //Till ex här använder jag StopDash så att jag endast kan dasha efter en sekund. 
        if (StopDash >= 1)
        {
            DashAllowed = true;
        }
        if (StopDash < 1)
        {
            DashAllowed = false;
        }
        // här gör jag så att DashSlow(som jag senare använder för att stoppa dashen) händer efter 0.1 sekund och om en egengjord trigger är true.
         if(StopDash >= 0.1 && (ok == true))
        {
            DashSlow = true;
            //så att det blir som en trigger så sätter jag ok till false så att detta event bara händer en gång
            ok = false;
        }
    }

}
