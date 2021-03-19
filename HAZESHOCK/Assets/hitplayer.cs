using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitplayer : MonoBehaviour
{
    public Transform playerpos;
    public Transform npcpos;
    public float npc_attack_damage = 20f;
    void Start()
    {
        npcpos = GetComponent<Transform>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            Debug.Log("Player Took Damage! : ");
            FindObjectOfType<playerlife>().DamagePlayer(npc_attack_damage);
        }
    }
    /*void Update()
    {
       float dist = Vector3.Distance(playerpos.position, npcpos.position);
       Debug.Log(dist);
       
        if (dist <= 1.5)
        {
            Debug.Log("Player Took Damage! : " );
            Debug.Log(dist);
            FindObjectOfType<playerlife>().DamagePlayer(npc_attack_damage);
        }
    }*/
}
