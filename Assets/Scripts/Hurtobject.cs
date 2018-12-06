using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hurtobject : MonoBehaviour
{
    //om objektet rör nåt
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //om det råkar vara Player
        if(collision.gameObject.tag == "Player")
        {
            GameObject controller = GameObject.FindWithTag("GameController");
            if (controller != null)
            {
                HealthTracker tracker = controller.GetComponent<HealthTracker>();
                if (tracker != null)
                {
                    tracker.ChangeHealth -= 1;
                }
                else
                {
                    Debug.LogError("HealthTracker saknas på GameController");
                }
            }
            else
            {
                Debug.LogError("GameController finns inte");
            }
            Scene active = SceneManager.GetActiveScene();
            SceneManager.LoadScene(active.name);
            
        }
    }

}
