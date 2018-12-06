using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPowerup : MonoBehaviour
{
    //använder mig av groundcheck scriptet
    public Groundcheck groundCheck;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //om objektet rör Player så ökas jumplimit inten i groundcheck med 1 och sedan förstör sig själv
        if (collision.tag == "Player")
        {
            groundCheck.JumpLimit += 1;
            Destroy(gameObject);
        }
    }
}
