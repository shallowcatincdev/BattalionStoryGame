using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void GoOutside()
    {
        SceneManager.LoadScene(2);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
