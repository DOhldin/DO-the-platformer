using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundcheck : MonoBehaviour
{
    public int touches;
    public int JumpLimit = 1;
    //Gör så att när objektets hitbox som scripten är kopplat till nuddar något så blir touches 0,
    public void OnTriggerEnter2D(Collider2D collision)
    {
        touches = 0;
    }
    //denna används inte
    public void OnTriggerExit2D(Collider2D collision)
    {
        //touches--;
    }
}
