using UnityEngine;

public class gatescript : MonoBehaviour
{
    public Vector3 newpos;
    public float gatespeed = 2f;
    // Start is called before the first frame update
    void Start() {
        newpos.x = transform.position.x;
        newpos.y = 15.55f;
        newpos.z = transform.position.z;
        
    }

    // Update is called once per frame

    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, newpos, gatespeed);
    }
    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            transform.position = Vector3.MoveTowards(transform.position, newpos, gatespeed);
        }
    }*/
}
