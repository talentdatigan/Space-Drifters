using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public GameObject trail;
    public GameObject player;
    public float speed;
    private Vector3 distance;
   
    
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (this.transform.position.magnitude > 300)
        {
            this.transform.position = new Vector3(player.transform.position.x + 5, player.transform.position.y + 5, player.transform.position.z + 6);
        } 
        trail.transform.position = this.transform.position;
        distance = player.transform.position - this.transform.position;
        Vector3 dist = distance.normalized;
        rb.AddForce(dist * speed, ForceMode.Acceleration);
        
        
       
    }
}
