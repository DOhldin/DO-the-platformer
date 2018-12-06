using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawMonsterScript : MonoBehaviour
{
    public float movespeed = 5f;
    public int Switch = 1;
    public Rigidbody2D rbody;

    private void Start()
    {
        //rbody betyder rigidbody2d fysik
        rbody = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Invi-wall")
        {
            if (Switch < 5)
            {
                Switch += 1;
            }
            if (Switch ==5)
            {
                Switch = 1;
            }
        }
    }
    private void Update()
    {
        if(Switch == 1)
        {
            rbody.velocity = new Vector2(-movespeed, movespeed);
        }
        if (Switch == 2)
        {
            rbody.velocity = new Vector2(movespeed, movespeed);
        }
        if (Switch == 3)
        {
            rbody.velocity = new Vector2(movespeed, -movespeed);
        }
        if (Switch == 4)
        {
            rbody.velocity = new Vector2(-movespeed, -movespeed);
        }
    }
}
