using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float SkyRotationSpeed = 1.5f;
   
    public GameObject enemy;
    public GameObject trail;
    public GameObject explosiveEffect;
    public float explosionForce;
    Vector3 InitialPos = new Vector3(5, 5, 2);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        explosiveEffect.transform.position = this.transform.position;
       
        if (this.transform.position.magnitude > 300)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
      


        if (Input.GetKey(KeyCode.Space))
        {
            this.GetComponent<Rigidbody>().AddForce(transform.forward * explosionForce, ForceMode.Impulse);
            explosiveEffect.GetComponent<ParticleSystem>().Play();
        }

       
        trail.transform.position = this.transform.position;
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * SkyRotationSpeed);

    }

   void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Enemy")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }
}
