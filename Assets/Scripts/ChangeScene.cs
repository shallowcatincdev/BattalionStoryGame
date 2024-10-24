using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public void StartGame()
    {
        StartCoroutine(StartGamePaused());
    }

    public void GoOutside()
    {
        StartCoroutine(GoOutsidePaused());
    }

    public void RestartGame()
    {
        StartCoroutine(RestartGamePaused());
    }

    IEnumerator StartGamePaused()
    {
        yield return new WaitForSeconds(0.25f);
        SceneManager.LoadScene(1);
    }
    IEnumerator GoOutsidePaused()
    {
        yield return new WaitForSeconds(0.25f);
        SceneManager.LoadScene(2);
    }
    IEnumerator RestartGamePaused()
    {
        yield return new WaitForSeconds(0.25f);
        SceneManager.LoadScene(0);
    }
}
