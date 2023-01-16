using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingController : MonoBehaviour
{
    public float distanceTravelled = 0;
    Vector3 lastPosition;

    public float DistanceAllowedTravel;
    public float Characterspeed;
    public bool TurnAround;
    // Start is called before the first frame update
    void Start()
    {
        lastPosition = transform.position;
        //First position the player starts in
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position += new Vector3(Characterspeed * Time.deltaTime, 0, 0);
        //Move the player on the x axis by speed

        distanceTravelled += Vector3.Distance(transform.position, lastPosition);
        //The distance the player has traveled from their first position

        if(distanceTravelled > DistanceAllowedTravel)
        {
            distanceTravelled = 0;
            this.gameObject.transform.position = lastPosition;
            this.gameObject.transform.position += new Vector3(Characterspeed * Time.deltaTime, 0, 0);
            //Return to lastposition if they have traveled the allowed distance
        }
    }
}
