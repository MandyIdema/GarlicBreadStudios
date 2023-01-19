using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BringBallBack : MonoBehaviour
{

    public bool BallComeBack;
    public GameObject Ball;
    //Variables for finding the ball object we want to return to museum

    public GameObject Player;
    private Vector3 PlayerPos;
    //Player position we want the ball to go to

    void Start()
    {
        BallComeBack = false;
        PlayerPos = Player.transform.position;
    }

    void FixedUpdate()
    {
        BallReturn();
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
            Ball.transform.position = PlayerPos;
        }
    }
}
