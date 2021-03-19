using UnityEngine;

public class playerlife : MonoBehaviour
{
    public float playerhealth = 100f;
    public Transform playerpos;

    private void Start()
    {
        playerpos = GetComponent<Transform>();
    }

    public void DamagePlayer(float damage_amount)
    {
        playerhealth -= damage_amount;
        if( playerhealth <= 0 )
            FindObjectOfType<restartlevel>().endgame();
    }

    void Update()
    {
        //Vector3 dist = Vector.distance(playerpos.position, npcpos.position);

        if (playerpos.position.y < -15)
        {
            FindObjectOfType<restartlevel>().endgame();
        }
        
    }


}
