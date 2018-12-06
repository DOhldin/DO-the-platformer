using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    //if(Input.GetAxisRaw > 0)
    private float axis;
    [Range(0, 20f)]
    public float movespeed;

    public float jumpheight;

    public Rigidbody2D rbody;

    public Groundcheck groundCheck;

    public CanDash canDash;

    public bool move = true;

    

    

    // Use this for initialization
    void Start()
    {
        //rbody betyder rigidbody2d
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
     //gör så att man kan bara dasha ifall man tagit upp dash-powerupen som gör candash inten dashable plus 1
     if(canDash.Dashable > 0) 
     { 
        //ifall StopDash timern är mindre än 0.1 och leftshift är tryckt
        if (Input.GetKey(KeyCode.LeftShift) && canDash.StopDash < 0.1)
        {
            //move blir då false och dem nuvarande rbody krafterna fortsätter(om jag går höger och håller inne shift och släpper högerknappen så fortsätter Player att gå höger till ex.
            move = false;
            rbody.velocity = new Vector2(rbody.velocity.x, rbody.velocity.y);
        }
     }
     //om stopdash timern är över 0.1 så är move true.
        if (canDash.StopDash > 0.1)
        {
            move = true;
        }
        //om move är true
            if (move == true)
        {
            //rbody x-velocityn blir axis av dem horisontala knapparna(a,d,vänster,höger(joysticks också tror jag)) gånger movespeed.
            rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * movespeed, rbody.velocity.y);
        }
            //om space är nedtryckt och groundcheck inten touches är mindre än jumplimiten...
        if (Input.GetKeyDown(KeyCode.Space) && groundCheck.touches < groundCheck.JumpLimit)
        {
            //rbody y-velocityn blir detsamma som jumpheight floaten och touches ökar med 1
            rbody.velocity = new Vector2(rbody.velocity.x, jumpheight);
            groundCheck.touches += 1;
        }
        //bestämmde att dash är en movement så den ligger här. Om shift är nedtryckt och dashable är större än 0 och dashallowed är true
        if ((Input.GetKeyDown(KeyCode.LeftShift)) && (canDash.Dashable > 0) && (canDash.DashAllowed == true))
        {
            //ok boolen i candash blir true
            canDash.ok = true;
            //Spara hållet (input get axis raw)
            //stäng av rörelse
            //forcera karaktären att gå åt "Hållet"
            //Vänta, resetta
            // axis är ett värde som är detsamma som axisen man får från horisontal knapparna.
            axis = Input.GetAxisRaw("Horizontal");
            //här får x-velocityn movespeed gånger 5 och hållet är beroende om axis är mer eller mindre än noll.
            //vänster
            if (axis < 0)
            {
               rbody.velocity = new Vector2(-movespeed * 5, 0);
            }
            //höger
           if (axis > 0)
           {
               rbody.velocity = new Vector2(movespeed * 5, 0);
           }
           //om dashallowed är true resetas stopdash timern till 0
            if (canDash.DashAllowed == true)
            {
                canDash.StopDash = 0;
            }
        }
        //om dashslow är true så blir rbody x-velocityn den nuvarande x-velocityn delat på 8(såg bäst ut med 8) och dashslow blir false igen
        if (canDash.DashSlow == true)
        {
            rbody.velocity = new Vector2(rbody.velocity.x / 8 , rbody.velocity.y);
            canDash.DashSlow = false;
        }
    }
}
