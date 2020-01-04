using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NedAudioManager : MonoBehaviour
{
    public AudioClip[] clips;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayNedSound(int index)
    {
        audioSource.clip = clips[index];
        audioSource.Play();
    }
}
