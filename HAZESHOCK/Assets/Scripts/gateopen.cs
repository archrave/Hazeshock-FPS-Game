using UnityEngine;

public class gateopen : MonoBehaviour
{
    public GameObject gateref;
    private void OnTriggerEnter(Collider info)
    {
        if (info.CompareTag("Player"))
        {
            Debug.Log("VOID ENTER");
            gateref.GetComponent<gatescript>().enabled = true;
            //GetComponent<gatescript>().enabled = true;
        }
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        
       if (collision.collider.tag == "Player")
        {
            Debug.Log("collideed w gateswitch");
            gateref.GetComponent<gatescript>().enabled = true;
           
        }
    }*/
}
