using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishRequirements : MonoBehaviour
{
    public GameObject Ball_image;
    public GameObject prompt6;

    private void Awake()
    {
        this.gameObject.GetComponent<Renderer>().enabled = false;
        this.gameObject.GetComponentInChildren<Renderer>().enabled = true;
    }

    private void Update()
    {
        FinishRequirement();
    }
    public void FinishRequirement()
    {
        if(dropPoint.prizeDelivered)
        {
            Debug.Log("Done!");
            this.gameObject.GetComponent<Renderer>().enabled = true;
            this.gameObject.GetComponentInChildren<Renderer>().enabled = true;

            Ball_image.GetComponent<Renderer>().enabled = false;
            prompt6.SetActive(false);

        }
    }
}
