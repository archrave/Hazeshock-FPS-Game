using UnityEngine;

public class playerlife : MonoBehaviour
{
    public GameObject gameoverUI;
    public GameObject gunref;
    public float playerhealth = 100f;
    public updatehealth healthbar_ref;      //Taking a reference from the health slider script attached to the 'Health Bar' object
    public texthealth texthealth_ref;       //Taking a reference from the text health script attached to the 'Text' 
    public Animator bloodUIanimator;
    void Start()
    {
        healthbar_ref.SetMaxHealth(playerhealth);
        texthealth_ref.SetMaximumHealth(playerhealth);
    }

    public void DamagePlayer(float damage_amount)
    {
        playerhealth -= damage_amount;
        healthbar_ref.HealthSlider(playerhealth);
        bloodUIanimator.Play("Base Layer.bloodscreenanim", 0, 0f);

        if ( playerhealth <= 0 )
            PlayerIsDead();     
        else        
            texthealth_ref.ChangeTextHealth(playerhealth);
          
    }

    void Update()
    {
        //Vector3 dist = Vector.distance(playerpos.position, npcpos.position);

        if (transform.position.y < -15)
        {
            FindObjectOfType<restartlevel>().RestartLevel();
        }
        
    }
    void PlayerIsDead()
    {
        texthealth_ref.ChangeTextHealth(0f);
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;        //Freezes position and rotation
        // FindObjectofType<MouseLook>().enabled = false;
        gunref.GetComponent<shooting>().enabled = false;                                    //Unable to shoot now
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        gameoverUI.SetActive(true);
        // FindObjectOfType<restartlevel>().RestartLevel();
    }
}
