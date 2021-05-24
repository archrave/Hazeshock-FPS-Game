using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponswitch : MonoBehaviour
{
    public GameObject[] weapon;
    public GameObject hand2;
    [SerializeField]
    int i = 0;
    void Start()
    {
        if (weapon[0].gameObject.activeSelf)
            i = 0;
        else
            i = 1;
    }

    private void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
            NextWeapon();
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
            PreviousWeapon();
        
       /* if (Input.GetKeyDown(KeyCode.Q) && i == 1)
        {
            hand2.GetComponent<Animator>().Play("Base Layer.punchanim", 0, 0f);
            hand2.GetComponent<punch>().Melee();
        }*/
        
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
