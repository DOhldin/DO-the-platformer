using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setinvisible : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }
}
