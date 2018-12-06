using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Value : MonoBehaviour
{
    public int score = 1;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject controller = GameObject.FindWithTag("GameController");
            if(controller != null)
            {
                HealthTracker tracker = controller.GetComponent<HealthTracker>();
                if(tracker != null)
                {
                    tracker.ChangeHealth += score; 
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
        }
        Destroy(gameObject);
    }
}