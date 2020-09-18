using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour

{
    public Camera cam2;
    public GameObject player;
    public GameObject enemy;
    public GameObject pointer;
    public float rotationSpeed;
    Vector3 currentEulerAngles;
    private Vector3 offset;
    public float zoomSpeed;
    Renderer m_Renderer;
    private Vector2 screenBounds;
    Vector3 pointerOffset;
    Vector3 pointerEnemyOffset;

    // Start is called before the first frame update
    void Start()
    {
        cam2.enabled = false;
        offset = transform.position - player.transform.position;
        pointerOffset = transform.position - pointer.transform.position;
        m_Renderer = enemy.GetComponent<Renderer>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        pointerOffset = transform.position - pointer.transform.position;
        pointerEnemyOffset = enemy.transform.position - pointer.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()

    {
        pointer.GetComponent<SpriteRenderer>().enabled = false;
        float dist = pointerOffset.magnitude;
        pointer.transform.position = Camera.main.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0)).GetPoint(dist);
        pointerEnemyOffset = pointerEnemyOffset.normalized;
        pointer.transform.rotation = pointer.transform.rotation * Quaternion.Euler(pointerEnemyOffset);

        if (!m_Renderer.isVisible)
        {
            pointer.GetComponent<SpriteRenderer>().enabled = true;
        }
        
       

        if (Input.GetKey(KeyCode.F))
        {
            offset = new Vector3(offset.x - zoomSpeed, offset.y + zoomSpeed, offset.z - zoomSpeed);
        }
        if (Input.GetKey(KeyCode.G))
        {
            offset = new Vector3(offset.x + zoomSpeed, offset.y - zoomSpeed, offset.z + zoomSpeed);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            this.GetComponent<Camera>().enabled = !this.GetComponent<Camera>().enabled;
            cam2.enabled = !cam2.enabled;
        }
        transform.position = player.transform.position + offset;

        
    }
}
