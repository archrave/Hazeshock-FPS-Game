using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject destroyedVersion;
    public GameObject BigVersion;
    public float health = 80f;
    public void TakeDamage (float amount)
    {
        health -= amount;
        if( health <= 0f )
        {
            Die();
        }    
    }

    void Die()
    {
        GameObject cracked;
        if(GetComponent<Transform>().localScale.x > 1f)
           cracked = Instantiate(BigVersion, transform.position, transform.rotation); 
        else
           cracked = Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(cracked, 6f);
    }
}
