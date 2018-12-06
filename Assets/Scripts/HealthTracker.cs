using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//gör så att jag kan använda mig av textmeshpro
using TMPro; //<- "namespace"

//using UnityEngine.UI
public class HealthTracker : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    //static igen så jag kan behålla värdet mellan rum
    public static int health = 3;
    public int ChangeHealth;
    //Gör så att jag kan påverka och använda mig av värden i scriptet NextLevel i detta script.
    public NextLevel nextlevel;
    public string LeveltoloadS = "StartMenu";
    void Update()
    {
        //om health är större än 9 så blir health minus 1. Funkar som en health limit med limiten 9.
        if(health > 9)
        {
            health -= 1;
        }
        // ChangeHealth är en int som berättar att health ska ändras. om ChangeHealth är större än 0 så ska health ökas med 1 och ChangeHealth ska minska med 1. 
        if(ChangeHealth > 0)
        {
            health += 1;
            ChangeHealth -= 1;
        }
        //om ChangeHealth är mindre än 0 så ska health minskas med 1 och ChangeHealth ska ökas med 1.
        if (ChangeHealth < 0)
        {
            health -= 1;
            ChangeHealth += 1;
        }
        //om health är under 1 så blir health 3 igen och första scenen blir loadad och inten reset i nextlevel ökar med 1 så att kön på nivåer börjar om från början(ser man i NextLevel scriptet). Helt enkelt så startar spelet om.
        if (health < 1)
        {
            health = 3;
            SceneManager.LoadScene(LeveltoloadS);
            nextlevel.Reset += 1;
        }

        //Detta säger till Texten som visas med textmeshpro visas som Health x där x = inten Shealth
        scoreText.text = string.Format("Health; {0}", health);
    }
}
