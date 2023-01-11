using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watchEnable : MonoBehaviour
{

    public static bool UISetActive = false;
    public GameObject RHand;

    private void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == RHand)
        {
            UISetActive = true;
           
        }
    }
}
