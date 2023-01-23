using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEnabler : MonoBehaviour
{

    public AudioSource promptOne;
    public AudioSource promptTwo;
    // Start is called before the first frame update
    void Start()
    {
        //promptOne = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "promptTrigger")
        {
            promptOne.Play();
            //Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "promptTrig")
        {
            promptTwo.Play();
            promptOne.Stop();
            //Destroy(other.gameObject);
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
