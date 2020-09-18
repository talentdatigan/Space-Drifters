using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RotatingSky : MonoBehaviour
{
    public float skyRot = 5f;
   
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * skyRot);
    }
}
