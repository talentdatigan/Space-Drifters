using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public GameObject[] spheres;
    public int GravityPull;
    public float rotationSpeed = 30;
    private Quaternion planetRotation;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (GameObject sphere in spheres)
        {
            Vector3 difference = this.transform.position - sphere.transform.position;
            float dist = difference.magnitude;
            Vector3 GravityDirection = difference.normalized;
         

            float gravity = (this.transform.localScale.x * sphere.transform.localScale.x * GravityPull) / (dist * dist);
            Vector3 GravityVector = gravity * GravityDirection;

            sphere.transform.GetComponent<Rigidbody>().AddForce(transform.forward, ForceMode.Acceleration);
            sphere.transform.GetComponent<Rigidbody>().AddForce(GravityVector, ForceMode.Acceleration);
        }
        Vector3 RotationVector = new Vector3(0, rotationSpeed, 0);
        planetRotation = Quaternion.Euler(RotationVector);
        transform.rotation = transform.rotation * planetRotation;

    }
}
