using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        BallPosition();
    }

    void BallPosition()
    {
        if (BringBallBack.BallComeBack)
        {
            GameObject Ball_Find = GameObject.FindGameObjectWithTag("ball");
            Ball_Find.transform.position = this.gameObject.transform.position;
            BringBallBack.BallComeBack = false;
        }
    }
}
