using UnityEngine;

public class shooting : MonoBehaviour
{
    public AudioSource gunsound;
    public float damage = 20f;
    public float headdamage = 100f;
    public float range = 500f;
    public float firerate = 3f;
    public float shootforce = 6000f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;
    //public GameObject pivotref;
    public ParticleSystem bulletGraphic;
    public Animator animatorref,shooterref;

    private float nexttimetofire = 0f;
    // Update is called once per frame
    private void Start()
    {
        gunsound = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time >= nexttimetofire)               //GetButtonDown for pistol maybeInput.GetMouseButtonDown(0
        {
            
            nexttimetofire = Time.time + 1f / firerate;
            Shoot();
        }
   
    }
    void Shoot()
    {
        
        muzzleFlash.Play();
        bulletGraphic.Play();
        animatorref.Play("Base Layer.rifleanimation", 0, 0f);
        shooterref.Play("Base Layer.shooteranim", 0, 0f);
        gunsound.Play();
        RaycastHit hit;

        //  The following function returns a boolean value so if the ray hits something the following if statement runs
        //  The following function also shoots out a ray in the direction we want and within the range we want to set

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)) //out hit = unity stores all the information about the shot object in this hit variable
        {
           // Debug.Log(hit.transform.name);
            Debug.Log(hit.transform.tag);

            Target target = hit.transform.GetComponent<Target>();
            
            npcdamage npc = hit.transform.GetComponent<npcdamage>();
            if(target != null)      //Checks if we found the 'Target' Component/Script in the object we're shooting
            {
                target.TakeDamage(damage);
            }
            if (npc != null)        //Checks if we found the 'npcdamage' Component/Script in the object we're shooting
            {
                if (hit.collider.tag== "head")
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
