using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public static int ActiveLevel;
    public int Reset;
    public string leveltoload0 = "LevelOne";
    public string leveltoload = "LevelTwo";
    public string leveltoload2 = "VictoryLevel";
    // om något aktiverar collision 2d triggern
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //om objektet har collision med player
        if(collision.tag=="Player")
        {
            //ifall om Activelevel är 0 så loadas LevelOne
            if (ActiveLevel == 0)
            {
                print("GJ");
                SceneManager.LoadScene(leveltoload0);
            }
            //ifall om Activelevel är 1 så loadas LevelTwo
            if (ActiveLevel == 1)
            {
                print("GJ");
                SceneManager.LoadScene(leveltoload);
            }
            //ifall om Activelevel är 2 så loadas VictoryLevel
            if (ActiveLevel == 2)
            {
                print("you win");
                SceneManager.LoadScene(leveltoload2);
            }
            //ActiveLevel blir plus 1 så att det blir som slags kö
            ActiveLevel += 1;
        }
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //ifall Reset är större 0 så börjar ActiveLevel kön om igen och reset blir noll
        if (Reset > 0)
        {
            ActiveLevel = 0;
            Reset = 0;
        }
    }
}
