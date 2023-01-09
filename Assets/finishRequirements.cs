using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishRequirements : MonoBehaviour
{

    private void Awake()
    {
        this.gameObject.GetComponent<Renderer>().enabled = false;
    }

    private void Update()
    {
        FinishRequirement();
    }
    public void FinishRequirement()
    {
        if(dropPoint.prizeDelivered && dropPoint1.prizeDelivered && dropPoint2.prizeDelivered)
        {
            Debug.Log("Done!");
            this.gameObject.GetComponent<Renderer>().enabled = true;
        }
    }
}
