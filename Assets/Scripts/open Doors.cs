using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoors : MonoBehaviour
{
    public GameObject doorLeft;
    public GameObject doorRight;
    void OnTriggerEnter(Collider other)
    {
        doorRight.transform.Translate(0.0f, 0.0f, 5.0f);
        doorLeft.transform.Translate(0.0f, 0.0f, -5.0f);
    }
    //x: 39
    //y: 4.2
    //move right door to z: 35
    //move left door to z: 19
    void OnTriggerExit(Collider other)
    {
        doorRight.transform.Translate(0.0f, 0.0f, -5.0f);
        doorLeft.transform.Translate(0.0f, 0.0f, 5.0f);
    }
    //move doors back to starting position
}
