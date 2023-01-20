using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject Ball_Find = GameObject.FindGameObjectWithTag("ball");
        Ball_Find.transform.position = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BallFind()
    {
        
    }
}
