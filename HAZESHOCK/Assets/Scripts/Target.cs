using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject destroyedVersion;
    public float health = 50f;
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
        GameObject cracked = Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(cracked, 6f);
    }
}
