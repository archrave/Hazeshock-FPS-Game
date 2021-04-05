using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gatescript2 : MonoBehaviour
{
    public Vector3 newpos;
    public float gatespeed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        newpos.x = transform.position.x;
        newpos.y = 5.5f;
        newpos.z = transform.position.z;

    }

    // Update is called once per frame

    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, newpos, gatespeed);
    }
}
