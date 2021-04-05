using UnityEngine;

public class gateclose : MonoBehaviour
{
    public GameObject gateref;
    private void OnTriggerEnter(Collider info)
    {
        if (info.CompareTag("Player"))
        {
            Debug.Log("VOID ENTER after");
            gateref.GetComponent<gatescript2>().enabled = true;
            //GetComponent<gatescript>().enabled = true;
        }
    }
}
