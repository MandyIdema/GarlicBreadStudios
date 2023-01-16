using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collissionTrigger : MonoBehaviour
{
    Vector3 StartPosition;

    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "soccerPlayer")
        {
            this.gameObject.transform.position = StartPosition;
            Debug.Log("player touched restart!");
        }
    }
}
