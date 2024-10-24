using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CarEnding : MonoBehaviour
{
    public GameObject car;
    public GameObject cam;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] GameObject fade;

    string dialog = "You left your family behind and never came back. THE END.";
    int charNum;
    string sentence;
    int delay;


    public void OnClick()
    {
        SceneManager.LoadScene(0);
    }
   

    private void FixedUpdate()
    {
        delay++;
        car.transform.Translate(Vector3.forward * 1f);
        cam.transform.Rotate(-0.5f, 0f, 0f);

        if (dialog.Length > charNum && delay % 2 == 0)
        {
            sentence += dialog[charNum];
            charNum++;
            text.text = sentence;
        }


        var temp = fade.GetComponent<Image>().color;
        temp.a += 0.01f;
        fade.GetComponent<Image>().color = temp;
    }

}
