using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioClip[] audioClip;
    [SerializeField] AudioSource soundSources;
    [SerializeField] AudioSource effectSource;

    public void SoundCall(int count)
    {
        effectSource.PlayOneShot(audioClip[count]);
    }

    public void Volume(float volume)
    {
        soundSources.volume = volume;   
    }
}
