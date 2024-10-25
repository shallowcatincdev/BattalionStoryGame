using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class NarratorScene2 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] PickUpMilk milk;

    int delay;

    string[] dialog = new string[] 
    {
        "You leave the house heading across the street to the big red store to get milk.",
        "After collecting the milk, you head back home, not questioning the fact that you haven't paid for it. No one is here to stop you, anyway.",
        "As you aproch the house you see your car parked on the side of the road, you get this feeling from it, this feeling of freedom. Do you fall for the temptation?"
    };
    string sentence;
    int charNum;
    bool printing = true;
    int dialogPoint = 1;
    bool milkShown;

    private void FixedUpdate()
    {

        if (milk.gotMilk && !milkShown)
        {
            milkShown = true;
            OnClick();
            
            dialogPoint = 2;
            printing = true;
        }

        delay++;
        if (dialogPoint == 1)
        {
            if (printing && dialog[0].Length > charNum && delay % 2 == 0)
            {
                sentence += dialog[0][charNum];
                charNum++;
                text.text = sentence;
            }
            if (sentence == dialog[0])
            {
                sentence = null;
                charNum = 0;
                printing = false;
            }
        }

        if (dialogPoint == 2)
        {
            if (printing && dialog[1].Length > charNum && delay % 2 == 0)
            {
                sentence += dialog[1][charNum];
                charNum++;
                text.text = sentence;
            }
            if (sentence == dialog[1])
            {
                sentence = null;
                charNum = 0;
                printing = false;
            }
        }

        if (dialogPoint == 3)
        {
            if (printing && dialog[2].Length > charNum && delay % 2 == 0)
            {
                sentence += dialog[2][charNum];
                charNum++;
                text.text = sentence;
            }
            if (sentence == dialog[2])
            {
                sentence = null;
                charNum = 0;
                printing = false;
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        
    
        if (other.gameObject.tag == "roadTrigger" && milk.gotMilk)
        {
            OnClick();

            dialogPoint = 3;
            printing = true;
        }
    }


    public void OnClick()
    {
        if (!printing && dialogPoint != 0)
        {
            text.text = null;
            dialogPoint = 0;
            printing = true;

        }
    }
}
