using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHealth : MonoBehaviour
{
    public GameObject healthsp1;
    public GameObject healthsp2;

    Vector3 health_location1;
    Vector3 health_location2;
    public float healthspawnInterval = 5f;
    float searchCD = 2f;

    // Start is called before the first frame update
    bool IshealthThere(Vector3 loc)
    {

        searchCD -= Time.deltaTime;
        if (searchCD <= 0f)
        {
            searchCD = 1f;
            Collider[] intersecting = Physics.OverlapSphere(loc, 0.01f);
            if (intersecting.Length == 0)
            {
                Debug.Log("HEALTH ISNT Here at: " + loc);
                return false;
            }
            else
                return true;
        }
        else
            return true;
            
    }
    public GameObject healthob;

    private void Start()
    {
        health_location1 = healthsp1.transform.position;
        health_location2 = healthsp2.transform.position;
    }
    void Update()
    {
        if(!IshealthThere(health_location1))
        {
            StartCoroutine(spawnTheHealth(health_location1));      
        }
        if (!IshealthThere(health_location2))
        {
            StartCoroutine(spawnTheHealth(health_location2));
        }
       // Debug.Log(health_location1);
       // Debug.Log(healthsp1.transform.position);

    }

    IEnumerator spawnTheHealth(Vector3 locat)
    {
        yield return new WaitForSeconds(healthspawnInterval);
        Debug.Log("Spawning Health...");
        GameObject ob1 = Instantiate(healthob);
        ob1.transform.position = locat;
        yield break;
    }
}
