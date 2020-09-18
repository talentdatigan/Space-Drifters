using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleStartOnVelocity : MonoBehaviour
{
    private float time = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<ParticleSystem>().Stop();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time = time + Time.fixedDeltaTime;
        Vector3 currentPos = transform.position;
        if ( time  > 2 && currentPos.magnitude > 1)
        {
            this.GetComponent<ParticleSystem>().Play();
            time = 0.0f;
            this.GetComponent<ParticleSystem>().Stop(); 
        }
    }
}
