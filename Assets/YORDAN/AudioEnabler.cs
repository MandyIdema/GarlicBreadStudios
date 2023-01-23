using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEnabler : MonoBehaviour
{
    public AudioSource promptOne;
    public AudioSource promptTwo;
    public AudioSource promptThree;
    public AudioSource promptFour;
    public AudioSource promptFive;
    public AudioSource promptSix;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "promptTrigger")
        {
            promptOne.Play();
            promptTwo.Stop();
            promptThree.Stop();
            promptFour.Stop();
            promptFive.Stop();
            promptSix.Stop();
        }

        if (other.gameObject.tag == "promptTrig")
        {
            promptTwo.Play();
            promptOne.Stop();
            promptThree.Stop();
            promptFour.Stop();
            promptFive.Stop();
            promptSix.Stop();
        }

        if (other.gameObject.tag == "canvas2")
        {
            promptTwo.Stop();
            promptOne.Stop();
            promptThree.Play();
            promptFour.Stop();
            promptFive.Stop();
            promptSix.Stop();
        }

        if (other.gameObject.tag == "canvas3")
        {
            promptTwo.Stop();
            promptOne.Stop();
            promptThree.Stop();
            promptFour.Play();
            promptFive.Stop();
            promptSix.Stop();
        }

        if (other.gameObject.tag == "canvas4")
        {
            promptTwo.Stop();
            promptOne.Stop();
            promptThree.Stop();
            promptFour.Stop();
            promptSix.Stop();
            promptFive.Play();
        }

        if (other.gameObject.tag == "canvas5")
        {
            promptTwo.Stop();
            promptOne.Stop();
            promptThree.Stop();
            promptFour.Stop();
            promptFive.Stop();
            promptSix.Play();
        }
    }
}
