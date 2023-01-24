using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watchEnable : MonoBehaviour
{

    public static bool UISetActive = false;
    public GameObject RHand;


    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == RHand)
        {
            UISetActive = !UISetActive;
            Debug.Log(" Watch touched");

            //Make a button so if the hand touches the wristwatch turn it on and off
        }
    }
}
