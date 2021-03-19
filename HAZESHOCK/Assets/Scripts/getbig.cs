using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getbig : MonoBehaviour
{
    public Transform obstaclebody;
    public float newsize = 5f;
    public float oldsize;
    Vector3 temp;
    void Start()
    {
        obstaclebody = GetComponent<Transform>();
        oldsize = obstaclebody.localScale.x;
    }

    void OnCollisionEnter(Collision info)
    {
        //Debug.Log("Obstacle is collided with something!");
        if (info.collider.tag == "Player")
        {
            temp.x = newsize;
            temp.y = newsize;
            temp.z = newsize;
            obstaclebody.localScale = temp;
        }
    }
}

