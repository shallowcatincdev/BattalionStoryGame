using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MilkEnding : MonoBehaviour
{
    
    public float camSpeed;

    public GameObject cam;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] GameObject fade;

    string dialog = "You returned home to your wife milk in hand hoping this marks a new begining. THE END.";
    int charNum;
    string sentence;
    int delay;


    public void OnClick()
    {
        SceneManager.LoadScene(0);
    }

    void FixedUpdate()
    {
        cam.transform.Translate(Vector3.forward * camSpeed);

        delay++;

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
