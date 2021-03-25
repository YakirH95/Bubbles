using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    AudioSource AS;

    public AudioClip pop;
    public AudioClip smallPop;
    public AudioClip newBubbles;

    private void Start()
    {
        AS = GetComponent<AudioSource>();
    }
    public void playPop()
    {
        AS.PlayOneShot(pop);
    }

    public void playSmallPop()
    {
        AS.PlayOneShot(smallPop);
    }

    public void playNewBubbles()
    {
        AS.PlayOneShot(newBubbles);
    }

}
