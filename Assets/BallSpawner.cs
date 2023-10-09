using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallSpawner : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame

    public GameObject Player;
    public GameObject Spawnpoint_player;

    public GameObject ball_spawnpoint;

    void FixedUpdate()
    {
        BallPosition();
    }

    void BallPosition()
    {
        if (BringBallBack.BallComeBack)
        {
            GameObject Ball_Find = GameObject.FindGameObjectWithTag("Ball");
            Ball_Find.transform.position = ball_spawnpoint.gameObject.transform.position;

            Player.transform.position = Spawnpoint_player.transform.position;

            BringBallBack.BallComeBack = false;


        }
    }
}
