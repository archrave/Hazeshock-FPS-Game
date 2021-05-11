using System.Collections;
using UnityEngine;

public class FillHealth : MonoBehaviour
{
    public Animator healthgainUI;
  //  public GameObject healthgainUI;
    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.collider.tag == "Player")
        {
            FindObjectOfType<playerlife>().playerhealth = 100f;
            FindObjectOfType<updatehealth>().HealthSlider(100f);
            FindObjectOfType<texthealth>().ChangeTextHealth(100f);
           // healthgainUI.Play("Base Layer.healthGain", 0, 0f);
            //healthgainUI.SetTrigger("healthgained");
            PassToSpawner();
            Destroy(gameObject);
        }

    }

    void PassToSpawner()
    {
        FindObjectOfType<Healthspawner>().SpawnWaitHealth();
    }
}
