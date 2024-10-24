using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterHome : MonoBehaviour
{
    public GameObject homeText;
    public PickUpMilk milk;
    public AudioSource click;

    bool colide;

    void Start()
    {
        homeText.SetActive(false);
    }
    void OnTriggerEnter(Collider Player)
    {
        colide = true;
        if (milk.gotMilk == true)
        {
            homeText.SetActive(true);
        }
        else
        {
            homeText.SetActive(false);
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
        homeText.SetActive(false);
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(0.25f);
        SceneManager.LoadScene(4);
    }
}
