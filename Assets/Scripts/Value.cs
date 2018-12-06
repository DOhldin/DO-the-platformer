using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Value : MonoBehaviour
{
    //hur mycket hp objektet får när eventet händer.
    public int hp = 1;
    //om colliderns trigger startar...
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //om collision med Player
        if (collision.tag == "Player")
        {
            //controller betyder objektet som har namnet GameController 
            GameObject controller = GameObject.FindWithTag("GameController");
            //om controller inte inte fungerar(alltså fungerar)
            if(controller != null)
            {
                //tracker betyder controllerns script Healthtracker
                HealthTracker tracker = controller.GetComponent<HealthTracker>();
                //om tracker inte inte fungerar
                if(tracker != null)
                {
                    //tracker inten Changehealth får hp
                    tracker.ChangeHealth += hp; 
                }
                else
                {
                    //annars skriv detta ""
                    Debug.LogError("HealthTracker saknas på GameController");
                }
            }
            else
            {
                //annars skriv detta ""
                Debug.LogError("GameController finns inte");
            }
        }
        //förstör en själv sist
        Destroy(gameObject);
    }
}