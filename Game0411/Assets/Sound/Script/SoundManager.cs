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
        effectSource.PlayOneShot(audioClips[count]);    //playoneshot: �������� ���ÿ� ȣ���ϰ� ������.
    }

    public void Volume(float volume)
    {
        soundSource.volume = volume;
    }
}
