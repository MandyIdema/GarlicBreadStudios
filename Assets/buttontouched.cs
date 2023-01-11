using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttontouched : MonoBehaviour
{
    public GameObject RHand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == RHand)
        {
            Debug.Log(" ButtonTouched");
        }
    }
}
