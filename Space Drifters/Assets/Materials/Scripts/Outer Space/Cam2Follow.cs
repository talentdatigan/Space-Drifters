using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam2Follow : MonoBehaviour
{
    public GameObject player;
    public float zoomSpeed;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = this.transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            offset = new Vector3(offset.x + zoomSpeed, offset.y - zoomSpeed, offset.z - zoomSpeed);
        }
        if (Input.GetKey(KeyCode.G))
        {
            offset = new Vector3(offset.x - zoomSpeed, offset.y + zoomSpeed, offset.z + zoomSpeed);
        }
        this.transform.position = player.transform.position + offset;
    }
}
