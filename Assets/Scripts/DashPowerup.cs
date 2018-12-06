using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashPowerup : MonoBehaviour
{
    public CanDash canDash;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //om detta objekt har collision med Player så ökas en int i CanDash med 1 och sedan Destroy(self)   
        if (collision.tag == "Player")
        {
            canDash.Dashable += 1;
            Destroy(gameObject);
        }
    }
}
