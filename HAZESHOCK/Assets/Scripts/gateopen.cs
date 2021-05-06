using UnityEngine;

public class gateopen : MonoBehaviour
{
    public GameObject gateref;
    private void OnTriggerEnter(Collider info)
    {
        if (info.CompareTag("Player"))
        {
           // Debug.Log("VOID ENTER");
            gateref.GetComponent<gatescript>().enabled = true;
            //GetComponent<gatescript>().enabled = true;
        }
    }

}
