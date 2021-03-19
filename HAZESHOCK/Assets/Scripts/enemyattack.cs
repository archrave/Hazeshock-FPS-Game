using UnityEngine;
using UnityEngine.AI;

public class enemyattack : MonoBehaviour
{
    Transform targ;
    NavMeshAgent agent;
    public float lookradius = 10f;

    void Start()
    {
        targ = findplayer.instance.playerhaha.transform;
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        float distance = Vector3.Distance(targ.position, transform.position);
        if(distance <= lookradius)
        {
            agent.SetDestination(targ.position);
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookradius);
    }
}
