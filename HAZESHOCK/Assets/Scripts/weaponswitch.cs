using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponswitch : MonoBehaviour
{
    public GameObject[] weapon;
    int i = 0;
    private void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
            NextWeapon();
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
            PreviousWeapon();
    }

    void NextWeapon()
    {
        weapon[i].SetActive(false);
        i++;
        i = i % weapon.Length;
        weapon[i].SetActive(true);
    }
    void PreviousWeapon()
    {
        weapon[i].SetActive(false);
        if (i == 0)
            i = weapon.Length - 1;
        else
            i--;
        weapon[i].SetActive(true);
    }
}
