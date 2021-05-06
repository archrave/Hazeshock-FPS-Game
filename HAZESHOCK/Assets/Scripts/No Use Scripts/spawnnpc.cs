using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnnpc : MonoBehaviour
{
    public GameObject npc1;
    public GameObject npc2;
    public GameObject npc3;
    public float score_ref;
    public float respawntime1 = 5f;
    public float respawntime2 = 3f;
    public float respawntime3 = 2f;
    void Start()
    {
        StartCoroutine(enemywave()); 
    }
    private void Spawn(GameObject npcname)
    {
        GameObject a = Instantiate(npcname) as GameObject;
        a.transform.position = new Vector3(Random.Range(-45f, 45f), 2, Random.Range(0, 145f));
    }
    IEnumerator enemywave()
    {
        while (true) {
            if (score_ref < 5f)
            {
                yield return new WaitForSeconds(respawntime1);
                Spawn(npc1);
            }
            else if (score_ref >= 5f && score_ref < 10f)
            {   
                yield return new WaitForSeconds(respawntime2);
                Spawn(npc2);
                Spawn(npc1);
            }
            else if (score_ref >= 10f)
            {               
                yield return new WaitForSeconds(respawntime3);
                Spawn(npc3);
                Spawn(npc2);
            }

        }
    }
    void Update()
    {
        score_ref = FindObjectOfType<updatescore>().score_count;
    }
  
}
