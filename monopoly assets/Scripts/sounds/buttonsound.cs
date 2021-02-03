using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonsound : MonoBehaviour
{
    public AudioSource buttonaudio;
    public AudioClip click;

    public void clicksound()
    {
        buttonaudio.PlayOneShot(click);
    }

   public void rollingdice()
    {
        buttonaudio.PlayOneShot(click);
    }

}
