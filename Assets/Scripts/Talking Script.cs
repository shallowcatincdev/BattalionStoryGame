using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkingScript : MonoBehaviour
{
    public GameObject wifeText;
    public GameObject innerThoughtText;
    public GameObject mainText;

    void Start()
    {
        wifeText.SetActive(false);
        innerThoughtText.SetActive(false);
        mainText.SetActive(false);
        StartCoroutine(TextPause());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TextPause()
    {
        wifeText.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        
        innerThoughtText.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        wifeText.SetActive(false);
        mainText.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        innerThoughtText.SetActive(false);
        yield return new WaitForSeconds(3.0f);
        mainText.SetActive(false);
    }
}
