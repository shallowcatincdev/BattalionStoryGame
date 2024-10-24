using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCam : MonoBehaviour
{
    public GameObject cam;
    void Start()
    {
        
    }


    void FixedUpdate()
    {
        cam.transform.Rotate(0.0f, 10.0f * Time.deltaTime, 0.0f);
    }
}
