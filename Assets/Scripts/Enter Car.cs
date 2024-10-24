using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterCar : MonoBehaviour
{
    public GameObject carText;
    public PickUpMilk milk;
    public AudioSource click;

    bool colide;

    void Start()
    {
        carText.SetActive(false);
    }
    void OnTriggerEnter(Collider Player)
    {
        colide = true;
        if (milk.gotMilk == true)
        {
            carText.SetActive(true);
        }
        else
        {
            carText.SetActive(false);
        }
        
    }

    private void Update()
    {
        if (milk.gotMilk && Input.GetKeyDown(KeyCode.E) && colide)
        {
            click.Play();
            StartCoroutine(ChangeScene());
        }
    }

    void OnTriggerExit(Collider Player)
    {
        colide = false;
        carText.SetActive(false);
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(0.25f);
        SceneManager.LoadScene(3);
    }
}
