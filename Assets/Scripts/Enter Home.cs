using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterHome : MonoBehaviour
{
    public GameObject homeText;
    public PickUpMilk milk;

    void Start()
    {
        homeText.SetActive(false);
    }
    void OnTriggerStay(Collider Player)
    {
        if (milk.gotMilk == true)
        {
            homeText.SetActive(true);
        }
        else
        {
            homeText.SetActive(false);
        }
        if (milk.gotMilk && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(4);
        }
    }

    void onTriggerExit(Collider Player)
    {
        homeText.SetActive(false);
    }
}
