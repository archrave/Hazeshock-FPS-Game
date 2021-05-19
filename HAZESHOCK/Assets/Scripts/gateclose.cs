using UnityEngine;

public class gateclose : MonoBehaviour
{
    public GameObject gateref;
    private void OnTriggerEnter(Collider info)
    {
        if (info.CompareTag("Player"))
        {          
            gateref.GetComponent<gatescript2>().enabled = true;
            FindObjectOfType<enemyspawn>().enabled = true;
        }
    }
}
