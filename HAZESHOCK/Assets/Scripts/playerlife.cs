using UnityEngine;

public class playerlife : MonoBehaviour
{
    public float playerhealth = 100f;
    public updatehealth healthbar_ref;      //Taking a reference from the health slider script attached to the 'Health Bar' object
    public texthealth texthealth_ref;       //Taking a reference from the text health script attached to the 'Text' 

    void Start()
    {
        healthbar_ref.SetMaxHealth(playerhealth);
        texthealth_ref.SetMaximumHealth(playerhealth);
    }

    public void DamagePlayer(float damage_amount)
    {
        playerhealth -= damage_amount;
        healthbar_ref.HealthSlider(playerhealth);
        if( playerhealth <= 0 )
        {
            texthealth_ref.ChangeTextHealth(0f);
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;        //Freezes postion but mouse moves
            FindObjectOfType<restartlevel>().endgame();
        }
        else
        {
            texthealth_ref.ChangeTextHealth(playerhealth);
        }
                
    }

    void Update()
    {
        //Vector3 dist = Vector.distance(playerpos.position, npcpos.position);

        if (transform.position.y < -15)
        {
            FindObjectOfType<restartlevel>().endgame();
        }
        
    }


}
