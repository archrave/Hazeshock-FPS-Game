using UnityEngine;

public class npcdamage : MonoBehaviour
{
    public float npchealth = 100f;
    public GameObject brokenhead;
    public GameObject brokenbody;

    //public float deathcause;
    public shooting sh;
    public void DoDamage(float amount)
    {
        //Debug.Log("Damage khaya: " + amount.ToString());
        npchealth -= amount;
        GetComponent<AudioSource>().Play();
        //Debug.Log("Life Bachi: " + npchealth.ToString());
        if (npchealth <= 0f)
        {
        
            Die(amount);
        }
    }

    void Die(float deathdamage)
    {

        if (deathdamage == sh.headdamage) //100f sh.headdamage
        {
            GameObject ob1 = Instantiate(brokenhead, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(ob1, 6f);
            FindObjectOfType<updatescore>().ChangeScore();
        }
        else if (deathdamage == sh.damage) //10f sh.headdamage
        {
            GameObject ob2 = Instantiate(brokenbody, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(ob2, 6f);
            FindObjectOfType<updatescore>().ChangeScore();

        }
    }
}
