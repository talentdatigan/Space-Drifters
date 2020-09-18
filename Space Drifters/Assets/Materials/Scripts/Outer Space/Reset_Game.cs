using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset_Game : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public int endGame = -3;
    

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < endGame) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
