using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStart : MonoBehaviour
{
    public string Level1 = "LevelOne";
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //om return är nedtryckt så loadas LevelOne
        if(Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(Level1);
        }
    }
}
