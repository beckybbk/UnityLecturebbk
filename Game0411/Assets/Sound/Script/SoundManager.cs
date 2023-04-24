using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioClip[] audioClips;
    [SerializeField] AudioSource soundSource;
    [SerializeField] AudioSource effectSource;

    public void SoundCall(int count)
    {
        effectSource.PlayOneShot(audioClips[count]);    //playoneshot: 여러개를 동시에 호출하고 싶을때.
    }

    public void Volume(float volume)
    {
        soundSource.volume = volume;
    }
}
