using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BringBallBack : MonoBehaviour
{

    public static bool BallComeBack;

    public Vector3 BallspawnPosition;
    //Variables for finding the ball object we want to return to museum
    //Player position we want the ball to go to

    void Start()
    {
    }

    void FixedUpdate()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "ball")
        {
            BallComeBack = true;
            Debug.Log("You can return with ball to museum");

        }
    }

    public void BallReturn()
    {
        if (BallComeBack)
        {
            GameObject Ball_Find = GameObject.FindGameObjectWithTag("ball");
            Ball_Find.transform.position = BallspawnPosition;
            BallComeBack = false;
        }
    }
}
