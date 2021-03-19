using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcdamage : MonoBehaviour
{
    public float npchealth = 100f;
    public GameObject brokenhead;
    public GameObject brokenbody;
    //public float deathcause;
    //shooting sh;
    public void DoDamage(float amount)
    {
        npchealth -= amount;
        if (npchealth <= 0f)
        {
        
            Die(amount);
        }
    }

    void Die(float deathdamage)
    {
        /* if (deathdamage == sh.damage)
         { 
             GameObject ob1 = Instantiate(brokenbody, transform.position, transform.rotation);
             Destroy(gameObject);
             Destroy(ob1, 6f);
         }
         else if(deathdamage == sh.headdamage)
         {
             GameObject ob2 = Instantiate(brokenhead, transform.position, transform.rotation);
             Destroy(gameObject);
             Destroy(ob2, 6f);
         }*/

        if (deathdamage == 100)
        {
            GameObject ob1 = Instantiate(brokenhead, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(ob1, 6f);
        }
        else if (deathdamage == 10)
        {
            GameObject ob2 = Instantiate(brokenbody, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(ob2, 6f);
        }
    }
}
