using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttontouched_museum : MonoBehaviour
{
    public GameObject RHand;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == RHand)
        {
            Debug.Log(" ButtonTouched");
            SceneManager.LoadScene("TROPHY ROOM SCENE");
        }
    }
}
