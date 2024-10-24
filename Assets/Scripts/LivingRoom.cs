using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class LivingRoom : MonoBehaviour
{
    [SerializeField] GameObject opt1Light;
    [SerializeField] GameObject opt2Light;
    [SerializeField] GameObject opt3Light;

    [SerializeField] Transform[] targets;

    [SerializeField] TextMeshProUGUI wifeText;
    [SerializeField] TextMeshProUGUI responseText;
    [SerializeField] TextMeshProUGUI narratorText;
    [SerializeField] GameObject optionPrompt;
    [SerializeField] TextMeshProUGUI optionText;

    [SerializeField] GameObject fade;

    int[,] speaking = new int[,] { {0, 2, 0, 0, 0, 0, 0}, {1, 2, 1, 2, 1, 2, 0}, {2, 1, 0, 0, 0, 0, 0}, {1, 2, 0, 0, 0, 0, 0} };

    string[] dialog1 = new string[] // Start
    {
        "You wake up on a dull day in a city where the sun never shines. You needed a beer and a smoke so you head to the living room and you see your wife in the kitchen while you sit down on the sofa.",
        "Took you long enough, YOU NEVER DO ANYTHING FOR THE FAMILY! WHY DID I GET MARRIED TO YOU?! YOU HAVE A TINY DICK! GTFO MY LIFE!.",
        "You sit there not wanting to deal with your wife’s bullshit, there are three paths you can choose: talking to your wife to calm her down, go grab some milk, have a pint."
    };

    string[] dialog2 = new string[] // Talk
    {
        "LISTEN I HAVE ENOUGH OF YOUR BULLSHIT! WE ARE SUPPOSED TO BE A HAPPY FAMILY BUT YOU KEEP MAKING MY LIFE MISERABLE.",
        "WELL IT’S NOT LIKE YOUR HELPING BECAUSE YOU KEEP NEGLECTING ME WHILE FOCUSING ON YOURSELF.",
        "THAT'S BECAUSE I NEED TIME FOR MYSELF.",
        "WHILE CLEARLY YOU HAVE TO MUCH!",
        "Maybe you're right, maybe I need to commit more as a husband to the family.",
        "well lets have a new start.",
        "and the couple restored their relationship and they lived happily ever after. THE END"
    };

    string[] dialog3 = new string[] // Beer
    {
        "OH DON’T YOU THINK BOOZE IS GOING TO SAVE YOU!",
        "SHUT THE FUCK UP YOU WHORE!",
        "And so you proceed to abuse your wife in which the neighbors overheard and called the police. You are now sentenced to life for domestic abuse. THE END."
    };

    string[] dialog4 = new string[] // Store
    {
        "I am going out to buy milk.",
        "Ok, you better buy the good one.",
        "And you went out to buy milk and never came home. THE END."
    };

    int dialogPoint = 0; // tracks where in the story we are

    Vector2 mousePos;
    Vector2 centerPos;

    bool printing = true;
    int option;
    bool posValid;
    string sentence;
    int delay;
    int charNum;
    bool passed;


    private void FixedUpdate()
    {
        delay++;
        // START


        if (dialogPoint == 0)
        {

            var temp = fade.GetComponent<Image>().color;
            temp.a -= 0.05f;
            fade.GetComponent<Image>().color = temp;

            if (printing && dialog1[0].Length > charNum && delay % 2 == 0)
            { 
                sentence += dialog1[0][charNum];
                charNum++;
                narratorText.text = sentence;
            }
            if (sentence == dialog1[0])
            {
                sentence = null;
                charNum = 0;
                printing = false;
            }
        }

        if (dialogPoint == 1)
        {
            

            if (printing && dialog1[1].Length > charNum && delay % 2 == 0)
            {
                sentence += dialog1[1][charNum];
                charNum++;
                wifeText.text = sentence;
            }
            if (sentence == dialog1[1])
            {
                charNum = 0;
                sentence = null;
                printing = false;
            }
        }

        if (dialogPoint == 2)
        {
            if (printing && dialog1[2].Length > charNum && delay % 2 == 0)
            {
                sentence += dialog1[2][charNum];
                charNum++;
                narratorText.text = sentence;
            }
            if (sentence == dialog1[2])
            {
                sentence = null;
                charNum = 0;
                printing = false;
            }
        }

        // STORE

        if (dialogPoint == 3)
        {
            if (printing && dialog4[0].Length > charNum && delay % 2 == 0)
            {
                sentence += dialog4[0][charNum];
                charNum++;
                responseText.text = sentence;
            }
            if (sentence == dialog4[0])
            {
                sentence = null;
                charNum = 0;
                printing = false;
            }
        }

        if (dialogPoint == 4)
        {
            if (printing && dialog4[1].Length > charNum && delay % 2 == 0)
            {
                sentence += dialog4[1][charNum];
                charNum++;
                wifeText.text = sentence;
            }
            if (sentence == dialog4[1])
            {
                sentence = null;
                charNum = 0;
                printing = false;
            }

            var temp = fade.GetComponent<Image>().color;
            temp.a += 0.05f;
            fade.GetComponent<Image>().color = temp;
        }

        if (dialogPoint == 5)
        {
            printing = false;
            SceneManager.LoadScene(2);
        }

        // BEER

        if (dialogPoint == 6)
        {
            if (printing && dialog3[0].Length > charNum && delay % 2 == 0)
            {
                sentence += dialog3[0][charNum];
                charNum++;
                wifeText.text = sentence;
            }
            if (sentence == dialog3[0])
            {
                sentence = null;
                charNum = 0;
                printing = false;
            }
        }

        if (dialogPoint == 7)
        {
            if (printing && dialog3[1].Length > charNum && delay % 2 == 0)
            {
                sentence += dialog3[1][charNum];
                charNum++;
                responseText.text = sentence;
            }
            if (sentence == dialog3[1])
            {
                sentence = null;
                charNum = 0;
                printing = false;
            }
        }

        if (dialogPoint == 8)
        {
            if (printing && dialog3[2].Length > charNum && delay % 2 == 0)
            {
                sentence += dialog3[2][charNum];
                charNum++;
                narratorText.text = sentence;
            }
            if (sentence == dialog3[2])
            {
                sentence = null;
                charNum = 0;
                printing = false;
            }
            var temp = fade.GetComponent<Image>().color;
            temp.a += 0.05f;
            fade.GetComponent<Image>().color = temp;
        }

        // TALK

        if (dialogPoint == 9)
        {
            if (printing && dialog2[0].Length > charNum && delay % 2 == 0)
            {
                sentence += dialog2[0][charNum];
                charNum++;
                responseText.text = sentence;
            }
            if (sentence == dialog2[0])
            {
                sentence = null;
                charNum = 0;
                printing = false;
            }
        }

        if (dialogPoint == 10)
        {
            if (printing && dialog2[1].Length > charNum && delay % 2 == 0)
            {
                sentence += dialog2[1][charNum];
                charNum++;
                wifeText.text = sentence;
            }
            if (sentence == dialog2[1])
            {
                sentence = null;
                charNum = 0;
                printing = false;
            }
        }

        if (dialogPoint == 11)
        {
            if (printing && dialog2[2].Length > charNum && delay % 2 == 0)
            {
                sentence += dialog2[2][charNum];
                charNum++;
                responseText.text = sentence;
            }
            if (sentence == dialog2[2])
            {
                sentence = null;
                charNum = 0;
                printing = false;
            }
        }

        if (dialogPoint == 12)
        {
            if (printing && dialog2[3].Length > charNum && delay % 2 == 0)
            {
                sentence += dialog2[3][charNum];
                charNum++;
                wifeText.text = sentence;
            }
            if (sentence == dialog2[3])
            {
                sentence = null;
                charNum = 0;
                printing = false;
            }
        }

        if (dialogPoint == 13)
        {
            if (printing && dialog2[4].Length > charNum && delay % 2 == 0)
            {
                sentence += dialog2[4][charNum];
                charNum++;
                responseText.text = sentence;
            }
            if (sentence == dialog2[4])
            {
                sentence = null;
                charNum = 0;
                printing = false;
            }
        }

        if (dialogPoint == 14)
        {
            if (printing && dialog2[5].Length > charNum && delay % 2 == 0)
            {
                sentence += dialog2[5][charNum];
                charNum++;
                wifeText.text = sentence;
            }
            if (sentence == dialog2[5])
            {
                sentence = null;
                charNum = 0;
                printing = false;
            }
        }

        if (dialogPoint == 15)
        {
            if (printing && dialog2[6].Length > charNum && delay % 2 == 0)
            {
                sentence += dialog2[6][charNum];
                charNum++;
                narratorText.text = sentence;
            }
            if (sentence == dialog2[6])
            {
                sentence = null;
                charNum = 0;
                printing = false;
            }
            var temp = fade.GetComponent<Image>().color;
            temp.a += 0.05f;
            fade.GetComponent<Image>().color = temp;
        }
    }

    void Update()
    {
        centerPos.x = mousePos.x - Screen.width / 2;
        centerPos.y = mousePos.y - Screen.height / 2;


        posValid = false;
        var xFlip = false;
        if (dialogPoint == 2 && !printing)
        {
            optionPrompt.SetActive(true);
            if (centerPos.x > 100 || centerPos.x < -100)
            {
                posValid = true;
            }
            if (centerPos.y < -100)
            {
                posValid = true;
            }

            if (posValid)
            {
                if (centerPos.x >= 0)
                {
                    centerPos.x *= -1;
                    xFlip = true;
                }

                if (centerPos.y < centerPos.x)
                {
                    option = 2;
                    optionText.text = "Have a drink.";
                    opt1Light.SetActive(false);
                    opt2Light.SetActive(true);
                    opt3Light.SetActive(false);
                }
                else if (!xFlip)
                {
                    option = 1;
                    optionText.text = "Talk to her.";
                    opt1Light.SetActive(true);
                    opt2Light.SetActive(false);
                    opt3Light.SetActive(false);
                }
                else
                {
                    option = 3;
                    optionText.text = "Head to the store.";
                    opt1Light.SetActive(false);
                    opt2Light.SetActive(false);
                    opt3Light.SetActive(true);
                }
            }

            if (!posValid)
            {
                option = 0;
                optionText.text = null;
                opt1Light.SetActive(false);
                opt2Light.SetActive(false);
                opt3Light.SetActive(false);
            }

            transform.rotation = Quaternion.Slerp(transform.rotation, targets[option].rotation, 1 * Time.deltaTime);
        }
    }

    void OnMousePos(InputValue value)
    {
        mousePos = value.Get<Vector2>();
    }

    void OnClick()
    {
        if (dialogPoint == 8 ||  dialogPoint == 15)
        {
            SceneManager.LoadScene(0);
        }

        else if (!printing && (dialogPoint != 2 || option > 0))
        {
            wifeText.text = null;
            responseText.text = null;
            narratorText.text = null;
            optionPrompt.SetActive(false);
            if (option != 0 && !passed)
            {
                if (option == 1)
                {
                    dialogPoint = 9;
                }
                else if (option == 2)
                {
                    dialogPoint = 6;
                }
                else
                {
                    dialogPoint = 3;
                }
                passed = true;
            }
            else
            {
                dialogPoint++;
            }
            printing = true;

        }
    }
}
