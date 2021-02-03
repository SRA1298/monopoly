using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovementsound : MonoBehaviour
{
    public static playermovementsound playersound;
    public AudioSource normalwalk;
    public AudioSource jailwalk;
    public AudioClip audio1;
    public AudioClip audio2;

    private void Awake()
    {
        makeinstance();
        normalwalk = gameObject.AddComponent<AudioSource>();
        jailwalk = gameObject.AddComponent<AudioSource>();
    }

    void makeinstance()
    {
        if (playersound == null)
        {
            playersound = this;
        }
    }
  
}
