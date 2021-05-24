using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class punch : MonoBehaviour
{
  
    public GameObject fpsCam;
    public float range = 1f;
    public float punchforce = 400f;
    public float punchdamage = 100f;
   
    
   void Update()
    {
        // hand2.GetComponent<BoxCollider>().enabled = true;

        if (Input.GetKeyDown(KeyCode.Q))
        {
            GetComponent<Animator>().Play("Base Layer.punchanim", 0, 0f);
            Invoke("Melee",0.1f);
        }

        // hand2.GetComponent<BoxCollider>().enabled = false;
    }
    

    public void Melee()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)) //out hit = unity stores all the information about the shot object in this hit variable
        {         
            npcdamage npc = hit.transform.GetComponent<npcdamage>();

            if (npc != null)        //Checks if we found the 'npcdamage' Component/Script in the object we're shooting
            {
                    npc.DoDamage(punchdamage);
            }
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * punchforce);
            }         
        }

    }


    /*
    void OnCollisionEnter(Collision info)
    {
        Debug.Log(info.collider.name);
        npcdamage npc = info.gameObject.GetComponent<npcdamage>();       //tag.transform.GetComponent<npcdamage>();
        if (info.collider.tag == "ENEMY" || info.collider.tag == "head" || info.collider.tag == "body")
        {
            if (npc != null)
            {
                Debug.Log("Meele attack!");
                npc.DoDamage(100f);
            }
        }
    }

    */
}

