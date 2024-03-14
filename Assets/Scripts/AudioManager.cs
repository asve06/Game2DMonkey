using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header(" - - - Audio Sources - - - ")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource effectsSounds;

    [Header(" - - - Audio Clips - - - ")]
    public AudioClip coin;
    public AudioClip death;



    public void PlaySound(AudioClip clip)
    {
        effectsSounds.PlayOneShot(clip);
    }
}
