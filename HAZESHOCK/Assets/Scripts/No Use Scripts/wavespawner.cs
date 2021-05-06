using System.Collections;
using UnityEngine;

public class wavespawner : MonoBehaviour
{

    public enum SpawnState { SPAWNING, WAITING, COUNTING };
    [System.Serializable]
    public class Wave
    {
        public string _name;
        public Transform enemy;
        public int cnt;
        public float spawndelay;
    }

    public Wave[] waves;
    private int nextWave = 0;
    public float timeBTWwaves = 5f;
    public float waveCountdown;

    public float SearchCountdown = 1f; //to search if an enemy is alive per second

    public SpawnState state = SpawnState.COUNTING;
    
    void Start()
    {
        waveCountdown = timeBTWwaves;
    }

    private void Update()
    {
        if(state == SpawnState.WAITING)
        {
            //Check if any enemy is alive
            if(!EnemyisAlive())
            {
                //Begin a new round
                WaveCompleted();
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
                StartCoroutine(Spawn_Wave(waves[nextWave]));
            }
        }
        else
        {
            waveCountdown -= Time.deltaTime;
        }
    }

    bool EnemyisAlive()
    {
        SearchCountdown -= Time.deltaTime;
        if (SearchCountdown <= 0f)
        {
            SearchCountdown = 1f;
            if (GameObject.FindGameObjectsWithTag("ENEMY").Length == 0)
            {
                //Debug.Log("ENEMY DED");
                return false;    
            }
        }
        //Debug.Log("****** Enemy is alive! *********");
        return true;
    }
    //When we have to create methods that wait for a certain time period before executing, we use IEnumerator instead of simple 'void'
    //IEnumerator uses System.Collections

    IEnumerator Spawn_Wave(Wave _wave)
    {
        Debug.Log("Spawning Wave: " + _wave._name);
        state = SpawnState.SPAWNING;
        
        for( int i = 0; i < _wave.cnt; i++)
        {
            SpawnEnemy(_wave.enemy);
            yield return new WaitForSeconds(_wave.spawndelay);
        }

        state = SpawnState.WAITING;
        yield break; 
    }

    void WaveCompleted()
    {
        Debug.Log("Wave KILLED!");
        state = SpawnState.COUNTING;
        waveCountdown = timeBTWwaves;
        if ( nextWave + 1 > waves.Length - 1 )//if the number 
        {
            nextWave = 0;
            Debug.Log("All Waves Complete! looping.......");
        }
        else
        {
            nextWave++;
        }
        
    }

    void SpawnEnemy(Transform _enemy)
    {
        Debug.Log("Spawning enemy! " + _enemy.name);
        Transform a = Instantiate(_enemy);
        //a.position = new Vector3(Random.Range(-45f, 45f), Random.Range(2, 15f), Random.Range(25, 145f));
        a.position = new Vector3(2f, 2f, 2f);
    } 
}
