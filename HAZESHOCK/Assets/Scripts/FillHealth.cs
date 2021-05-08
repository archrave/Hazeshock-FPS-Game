using System.Collections;
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
            PassToSpawner();
            Destroy(gameObject);
        }

    }

    void PassToSpawner()
    {
        FindObjectOfType<Healthspawner>().SpawnWaitHealth();
    }
}
