using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public GameObject solarFlares;
    public GameObject[] planets;
    public float GravPull;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (GameObject planet in planets)
        {
            Vector3 distance = this.transform.position - planet.transform.position;
            float dist = distance.magnitude;
            Vector3 gravDirection = distance.normalized;
            float Force = (this.transform.localScale.x * planet.transform.localScale.x * GravPull) / (dist * dist);
            Vector3 GravForce = gravDirection * Force;

            planet.GetComponent<Rigidbody>().AddForce(transform.forward, ForceMode.Acceleration);
            planet.GetComponent<Rigidbody>().AddForce(GravForce, ForceMode.Acceleration);
            
        }
        solarFlares.transform.position = new Vector3(transform.position.x, transform.position.y - 10, transform.position.z);
    }
}
