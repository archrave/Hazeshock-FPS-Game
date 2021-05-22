using UnityEngine;

public class pistol : MonoBehaviour
{
    public AudioSource gunsound;
    public float damage = 30f;
    public float headdamage = 100f;
    public float range = 400f;
    public float firerate = 3f;
    public float shootforce = 250f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;    
    public ParticleSystem bulletGraphic;
    public Animator animator;

    private float nexttimetofire = 0f;
    
    private void Start()
    {
        gunsound = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time >= nexttimetofire)               //GetButtonDown for pistol maybeInput.GetMouseButtonDown(0
        {

            nexttimetofire = Time.time + 1f / firerate;
            Fire();
        }

    }

    void Fire()
    {
        muzzleFlash.Play();
        bulletGraphic.Play();
        animator.Play("Base Layer.pistolanim", 0, 0f);
        Invoke("Shoot", 0.07f);
    }
    void Shoot()
    {
        
        gunsound.Play();
        RaycastHit hit;

        //  The following function returns a boolean value so if the ray hits something the following if statement runs
        //  The following function also shoots out a ray in the direction we want and within the range we want to set

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)) //out hit = unity stores all the information about the shot object in this hit variable
        {
            //Debug.Log(hit.collider.tag);

            Target target = hit.transform.GetComponent<Target>();

            //storing 'npcdamage' script/component in the npc object of the npcdamage class. iF the script isnt found, NULL would be stored in this

            npcdamage npc = hit.transform.GetComponent<npcdamage>();   

            if (target != null)      //Checks if we found the 'Target' Component/Script in the object we're shooting
            {
                target.TakeDamage(damage);
            }
            if (npc != null)        //Checks if we found the 'npcdamage' Component/Script in the object we're shooting
            {
                if (hit.collider.tag == "head")
                {
                    npc.DoDamage(headdamage);
                }
                else
                    npc.DoDamage(damage);
            }
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * shootforce);
            }
            GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 0.2f);
        }
    }
}
