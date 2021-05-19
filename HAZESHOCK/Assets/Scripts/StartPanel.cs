using UnityEngine;
using System.Collections;
public class StartPanel : MonoBehaviour
{
    public GameObject UI1,UI2,startpanel,player;
    public Animator startp;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        StartCoroutine(ShowStartPanel());
    }
    IEnumerator ShowStartPanel()
    {
        player.GetComponent<UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController>().enabled = false;
        FindObjectOfType<shooting>().enabled = false;
        Debug.Log("Start Panel ");       
        yield return new WaitForSeconds(1f);
        UI1.SetActive(true);
        yield return new WaitForSeconds(2f);
        UI1.SetActive(false);
        yield return new WaitForSeconds(1f);
        UI2.SetActive(true);
        yield return new WaitForSeconds(2f);
        UI2.SetActive(false);
        yield return new WaitForSeconds(1f);
        startp.Play("Base Layer.startpanelanim", 0, .3f);
        startpanel.SetActive(false);
        Debug.Log("Start Panel Over ");       
        FindObjectOfType<shooting>().enabled = true;
        player.GetComponent<UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController>().enabled = true;
        yield break;
    }
}
