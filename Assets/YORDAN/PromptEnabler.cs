using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PromptEnabler : MonoBehaviour
{
    public GameObject canvas;
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvas3;
    public GameObject canvas4;
    public GameObject canvas5;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "promptTrigger")
        {
            canvas.SetActive(true);
            Debug.Log("triggered");
        }

        if (other.tag == "promptTrig")
        {
            canvas1.SetActive(true);
            Debug.Log("triggered");
        }

        if (other.tag == "canvas2")
        {
            canvas2.SetActive(true);
            Debug.Log("triggered");
        }

        if (other.tag == "canvas3")
        {
            canvas3.SetActive(true);
            Debug.Log("triggered");
        }

        if (other.tag == "canvas4")
        {
            canvas4.SetActive(true);
            Debug.Log("triggered");
        }

        if (other.tag == "canvas5")
        {
            canvas5.SetActive(true);
            Debug.Log("triggered");
        }
    }
}
