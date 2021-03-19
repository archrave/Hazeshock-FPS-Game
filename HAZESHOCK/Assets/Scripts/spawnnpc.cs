using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnnpc : MonoBehaviour
{
    public GameObject npc;
    public float respawntime = 5f;
    void Start()
    {
        StartCoroutine(enemywave());
    }
    private void Spawn()
    {
        GameObject a = Instantiate(npc) as GameObject;
        a.transform.position = new Vector3(Random.Range(-45f, 45f), 2, Random.Range(0, 145f));
    }
    IEnumerator enemywave()
    {
        while (true) { 
            yield return new WaitForSeconds(respawntime);
            Spawn();
        }
    }
    void Update()
    {
        
    }
}
