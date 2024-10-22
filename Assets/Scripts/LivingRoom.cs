using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LivingRoom : MonoBehaviour
{
    [SerializeField] GameObject opt1Light;
    [SerializeField] GameObject opt2Light;
    [SerializeField] GameObject opt3Light;


    int dialogPoint = 3; // tracks where in the story we are

    Vector2 mousePos;
    Vector2 centerPos;

    int option;
    bool posValid;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        centerPos.x = mousePos.x - Screen.width / 2;
        centerPos.y = mousePos.y - Screen.height / 2;

        Debug.Log(centerPos);

        posValid = false;
        var xFlip = false;
        if (dialogPoint == 3) // value placeholder
        {
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

                    opt1Light.SetActive(false);
                    opt2Light.SetActive(true);
                    opt3Light.SetActive(false);
                }
                else if (!xFlip)
                {
                    option = 1;

                    opt1Light.SetActive(true);
                    opt2Light.SetActive(false);
                    opt3Light.SetActive(false);
                }
                else
                {
                    option = 3;

                    opt1Light.SetActive(false);
                    opt2Light.SetActive(false);
                    opt3Light.SetActive(true);
                }
            }

            if (!posValid)
            {
                option = 0;

                opt1Light.SetActive(false);
                opt2Light.SetActive(false);
                opt3Light.SetActive(false);
            }
        }
    }

    void OnMousePos(InputValue value)
    {
        mousePos = value.Get<Vector2>();
    }

    void OnClick()
    {

    }
}
