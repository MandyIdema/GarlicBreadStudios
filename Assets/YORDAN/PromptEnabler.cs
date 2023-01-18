using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PromptEnabler : MonoBehaviour
{
    public GameObject canvas;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "promptTrigger")
        {
            canvas.SetActive(true);
        }
    }
}
