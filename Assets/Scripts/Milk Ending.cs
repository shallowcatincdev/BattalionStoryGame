using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilkEnding : MonoBehaviour
{
    public GameObject cam;
    public GameObject ending;
    public GameObject restartButton;
    public float camSpeed;
    public GameObject[] dialog;
    void Start()
    {
        ending.SetActive(false);
        restartButton.SetActive(false);
        StartCoroutine(Pause());
        StartCoroutine(ShowDialog());
        for (int i = 0; i < dialog.Length; i++)
        {
            dialog[i].SetActive(false);
        }
    }
    
    void FixedUpdate()
    {
        cam.transform.Translate(Vector3.forward * camSpeed);
    }
    
    IEnumerator Pause()
    {
        yield return new WaitForSeconds(10f);
        for (int i = 0; i < dialog.Length; i++)
        {
            dialog[i].SetActive(false);
        }
        ending.SetActive(true);
        yield return new WaitForSeconds(2f);
        restartButton.SetActive(true);
    }

    IEnumerator ShowDialog()
    {
        for (int i = 0; i < dialog.Length; i++)
        {
            Debug.Log(i.ToString());
            dialog[i].SetActive(true);
            yield return new WaitForSeconds(1.0f);
        }
    }
}
