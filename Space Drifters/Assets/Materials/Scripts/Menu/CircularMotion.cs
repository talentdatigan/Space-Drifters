using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMotion : MonoBehaviour
{
    public float width;
    public GameObject trail;
    public float height;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        float x = Mathf.Sin(time) * width;
        float y = Mathf.Cos(time) * height;
        float z = 0;
        transform.position = new Vector3(x, y, z);
        trail.transform.position = transform.position;
    }
}
