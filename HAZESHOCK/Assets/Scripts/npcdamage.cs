using UnityEngine;

public class npcdamage : MonoBehaviour
{
    public float npchealth = 100f;
    public GameObject brokenhead;
    public GameObject brokenbody;
    public GameObject punchedbody;

    //public float deathcause;
    //public shooting sh;

    public void DoDamage(float amount)
    {
        Debug.Log("Damage khaya: " + amount.ToString());

        npchealth -= amount;
        GetComponent<AudioSource>().Play();

        //Debug.Log("Life Bachi: " + npchealth.ToString());

        if (npchealth <= 0f)
        {
            //Debug.Log("Die Function called");
            Die(amount);
        }
    }

    void Die(float deathdamage)
    {

        if(deathdamage == 220f)                                                                         //Exact amount of punch damage
        {
            GameObject ob2 = Instantiate(punchedbody, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(ob2, 6f);
            FindObjectOfType<updatescore>().ChangeScore();
        }

        else if (deathdamage >= 60f && deathdamage < 250f)                                              //100f sh.headdamage (headshot 60 se toh zyada hi hoga)
        {
            GameObject ob1 = Instantiate(brokenhead, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(ob1, 6f);
            FindObjectOfType<updatescore>().ChangeScore();
        }
        else                                                                                            //(deathdamage == sh.damage) //10f sh.headdamage
        {
            //Debug.Log("Pet se mara");
            GameObject ob3 = Instantiate(brokenbody, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(ob3, 6f);
            FindObjectOfType<updatescore>().ChangeScore();
        }
    }
}
