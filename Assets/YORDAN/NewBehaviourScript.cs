using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] GameObject player;

    void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - player.transform.position);
    }
}
//using a quaternion adjusts the rotation of the UI prompts in x and y coordinates depending on the player's position