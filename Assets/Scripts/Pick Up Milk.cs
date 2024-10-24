using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpMilk : MonoBehaviour
{
    public GameObject milkText;
    public GameObject milk;
    public GameObject objectiveText;

    public bool gotMilk = false;
    // Start is called before the first frame update
    void Start()
    {
        milkText.SetActive(false);
        objectiveText.SetActive(false);
    }

    private void OnTriggerStay(Collider Player)
    {
        if (gotMilk == false)
        {
            milkText.SetActive(true);
        }
        else
        {
            milkText.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject.Destroy(milk);
            gotMilk = true;
            objectiveText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider Player)
    {
        milkText.SetActive(false);
    }
}
