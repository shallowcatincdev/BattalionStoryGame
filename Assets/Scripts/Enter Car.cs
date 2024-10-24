using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterCar : MonoBehaviour
{
    public GameObject carText;
    public PickUpMilk milk;

    void Start()
    {
        carText.SetActive(false);
    }
    void OnTriggerStay(Collider Player)
    {
        if (milk.gotMilk == true)
        {
            carText.SetActive(true);
        }
        else
        {
            carText.SetActive(false);
        }
        if (milk.gotMilk && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(3);
        }
    }
    void OnTriggerExit(Collider Player)
    {
        carText.SetActive(false);
    }
}
