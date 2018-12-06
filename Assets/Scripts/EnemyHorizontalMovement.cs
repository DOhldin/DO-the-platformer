using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    public float movespeed = 2F;
    public bool isLeft = true;
    public Rigidbody2D rbody;
    // Use this for initialization
    void Start()
    {
        // för att få rigidbody
        rbody = GetComponent<Rigidbody2D>();
        //Move börjar med att vara false
        Move(false);
    }

    // Update is called once per frame
    void Update()
    {
        //detta är bara för att testa move med key H
       if(Input.GetKeyDown(KeyCode.H))
        {
            Move(true);
        }
    }
    //när Move är true ändras boolen flip antar jag.
    void Move(bool flip)
    {
        //om boolen flip som du ser över är true som blir boolen isLeft false
        if (flip == true)
        {
            isLeft = !isLeft;
        }
        // monstret rör sig med rigidbody med speeden av movespeed och får en ny storlek så monstret vänder sig och behåller en korrekt hitbox. Hållet som monstret är vänt och går åt är beroende på om isleft är true eller false
        if (isLeft == true)
        {
            rbody.velocity = new Vector2(-movespeed, rbody.velocity.y);
            transform.localScale = new Vector3(2, 2, 1);
        }
        else
        {
            rbody.velocity = new Vector2(movespeed, rbody.velocity.y);
            transform.localScale = new Vector3(-2, 2, 1);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //om objekten rör Invi-wall så blir move true
        if(collision.tag == "Invi-wall")
        {
            Move(true);
        }
    }

}
