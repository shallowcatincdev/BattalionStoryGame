using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpMilk : MonoBehaviour
{
    public GameObject milkText;
    public GameObject milk;
    public AudioSource click;

    public bool gotMilk = false;
    bool milkColide;
    // Start is called before the first frame update
    void Start()
    {
        milkText.SetActive(false);
    }

    private void OnTriggerEnter(Collider Player)
    {
        milkColide = true;
        if (gotMilk == false)
        {
            milkText.SetActive(true);
        }
        else
        {
            milkText.SetActive(false);
        }
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && milkColide)
        {
            click.Play();
            Destroy(milk);
            gotMilk = true;
        }
    }

    void OnTriggerExit(Collider Player)
    {
        milkColide = false;
        milkText.SetActive(false);
    }
}
