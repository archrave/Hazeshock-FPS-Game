using System.Collections;
using UnityEngine;

public class Healthspawner : MonoBehaviour
{
    public GameObject healthboxREF;
    public float HealthSpawnTime = 5f;
    IEnumerator SpawnTheHealthBox()
    {
        yield return new WaitForSeconds(HealthSpawnTime);
        Debug.Log("Spawning Health Box! at: " + transform.position);
        GameObject a = Instantiate(healthboxREF) as GameObject;
        a.transform.position = transform.position;
        yield break;
    }
    public void SpawnWaitHealth()
    {
        StartCoroutine(SpawnTheHealthBox());
    }
}
