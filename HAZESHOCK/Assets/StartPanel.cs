using UnityEngine;
using System.Collections;
public class StartPanel : MonoBehaviour
{
    public GameObject UI1,UI2,startpanel,player;
    public Animator startp;
    void Start()
    {
        StartCoroutine(ShowStartPanel());
    }
    IEnumerator ShowStartPanel()
    {
        //player.GetComponent<shooting>().SetActive(false);
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
        yield break;
    }
}
