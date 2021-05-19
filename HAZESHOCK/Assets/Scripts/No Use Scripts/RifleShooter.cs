using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifleShooter : MonoBehaviour
{
    public Animator animator;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            animator.SetBool("_shooter", true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            animator.SetBool("_shooter", false);
        }
    }
}
