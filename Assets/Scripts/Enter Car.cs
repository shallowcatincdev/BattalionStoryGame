using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterCar : MonoBehaviour
{
    public GameObject carText;
    public PickUpMilk milk;
    public AudioSource click;

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
            click.Play();
            StartCoroutine(ChangeScene());
        }
    }
    void OnTriggerExit(Collider Player)
    {
        carText.SetActive(false);
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(0.25f);
        SceneManager.LoadScene(3);
    }
}
