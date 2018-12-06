using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setinvisible : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //När scenen startar så blir spriten false(osynlig)
        GetComponent<SpriteRenderer>().enabled = false;
    }
}
