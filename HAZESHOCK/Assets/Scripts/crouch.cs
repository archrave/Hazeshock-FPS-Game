using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crouch : MonoBehaviour
{
    CapsuleCollider col;
    float originalHeight;
    public float reducedHeight = 1f;
    void Start()
    {
        col = GetComponent<CapsuleCollider>();
        originalHeight = col.height;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
            Crouch();
        else if (Input.GetKeyUp(KeyCode.LeftControl))
            GoUp();
    }

    void Crouch()
    {
        col.height = reducedHeight;
    }

    void GoUp()
    {
        col.height = originalHeight;
    }
}
