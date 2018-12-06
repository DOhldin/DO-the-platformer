using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hurtobject : MonoBehaviour
{
    //en int som säger hur mycket man skadas
    private int damage = 1;
    //om objektet rör nåt
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //om det råkar vara Player
        if(collision.gameObject.tag == "Player")
        {
            //controller betyder objektet som har namnet GameController 
            GameObject controller = GameObject.FindWithTag("GameController");
            ////om controller inte inte fungerar(alltså fungerar)
            if (controller != null)
            {
                //tracker betyder controllerns script Healthtracker
                HealthTracker tracker = controller.GetComponent<HealthTracker>();
                //om tracker inte inte fungerar
                if (tracker != null)
                {
                    //tracker inten Changehealth minskas med damage
                    tracker.ChangeHealth -= damage;
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
            //helt enkelt få den nuvarande scenen och loada den(en reset alltså)
            Scene active = SceneManager.GetActiveScene();
            SceneManager.LoadScene(active.name);
            
        }
    }

}
