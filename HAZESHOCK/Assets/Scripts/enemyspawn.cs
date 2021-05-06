using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class enemyspawn : MonoBehaviour
{
    public GameObject wavekillUI;
    public Transform[] NPC;
    public int enemycnt = 5;
    public float wavetime = 2f;
    public float enemyspawnInterval= 2f;
    float waveCountdown;


    float searchcountdown = 1f;
    int cnt = 0;
    int randEnemy;
    public enum SpawnState { SPAWNING, WAITING, COUNTING };
    public SpawnState state = SpawnState.COUNTING;
    void Start()
    {
        waveCountdown = wavetime;
    }
    bool EnemyisAmongUs()
    {
        searchcountdown -= Time.deltaTime;
        if (searchcountdown <= 0f)
        {
            searchcountdown = 1f;
            if (GameObject.FindGameObjectsWithTag("ENEMY").Length == 0)
            {
                //Debug.Log("ENEMY DED");
                return false;
            }
        }
        //Debug.Log("****** Enemy is alive! *********");
        return true;
    }

    void WaveKilled()
    {
            Debug.Log("Wave KILLED!");
            state = SpawnState.COUNTING;
            waveCountdown = wavetime;
            wavekillUI.SetActive(true);
            Invoke("Turn_Off_UI", 1f);
    }

    void Turn_Off_UI()
    {
        wavekillUI.SetActive(false);
    }
    IEnumerator Spawnthembitches()
    {
        Debug.Log("Spawning Wave no. : " + cnt);
        int highestpowerfulNPC;
        state = SpawnState.SPAWNING;
        if (enemycnt <= 10)
            highestpowerfulNPC = 0;          
        else if (enemycnt > 10 && enemycnt < 20)
            highestpowerfulNPC = 2;
        else
            highestpowerfulNPC = 3;

        for (int i = 0; i < enemycnt; i++)
        {
            randEnemy = Random.Range(0, highestpowerfulNPC);
            Transform a = Instantiate(NPC[randEnemy]);
            a.position = new Vector3(Random.Range(-45f, 45f), Random.Range(2, 20f), Random.Range(30f, 145f));         
            yield return new WaitForSeconds(enemyspawnInterval);
        }

        state = SpawnState.WAITING;
        enemycnt += 5;
        yield break;
    }


    void Update()
    {
        if (state == SpawnState.WAITING)
        {
            //Check if any enemy is alive
            if (!EnemyisAmongUs())
            {
                //Begin a new round
                WaveKilled();
                return;
            }
            else
            {
                return;
            }
        }

        if (waveCountdown <= 0)
        {
            if (state != SpawnState.SPAWNING)
            {
                // StartCououtine is how you call an IEnumerator function
                cnt++;
                StartCoroutine(Spawnthembitches());
            }
        }
        else
        {
            waveCountdown -= Time.deltaTime;
        }
    }

}
