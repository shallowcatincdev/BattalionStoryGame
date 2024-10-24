using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEnding : MonoBehaviour
{
    public GameObject car;
    public GameObject cam;
    public GameObject ending;
    public GameObject restartButton;
    void Start()
    {
        ending.SetActive(false);
        restartButton.SetActive(false);
        StartCoroutine(Pause());
    }
    
    void Update()
    {
        car.transform.Translate(Vector3.forward * 1.0f);
    }

    private void FixedUpdate()
    {
        cam.transform.Rotate(-1f, 0f, 0f);
    }

    IEnumerator Pause()
    {
        yield return new WaitForSeconds(2f);
        ending.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        yield return new WaitForSeconds(2f);
        restartButton.SetActive(true);
    }
}
