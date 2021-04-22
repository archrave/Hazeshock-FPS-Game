using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillHealth : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.collider.tag == "Player")
        {
            FindObjectOfType<playerlife>().playerhealth = 100f;
            FindObjectOfType<updatehealth>().HealthSlider(100f);
            FindObjectOfType<texthealth>().ChangeTextHealth(100f);
            Destroy(gameObject);
        }
    }

}
