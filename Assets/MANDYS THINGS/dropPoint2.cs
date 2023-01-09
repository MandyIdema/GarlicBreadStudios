using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropPoint2 : MonoBehaviour
{
    public GameObject prize;

    public static bool prizeDelivered;

    private void Awake()
    {
        prizeDelivered = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == prize)
        {
            Debug.Log("Delivered!");

            prizeDelivered = true;
        }
    }
}
