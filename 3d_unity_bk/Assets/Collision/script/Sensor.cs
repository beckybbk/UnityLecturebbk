using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Sensor : MonoBehaviour
{
    public Mesh[] mesh;

    private VideoPlayer video;
    private MeshFilter meshFilter;

    void Start()
    {
        meshFilter = GetComponent<MeshFilter>();
        video = GetComponent<VideoPlayer>();    
    }

    private void OnTriggerEnter(Collider other)
    {
        video.Play();
        video.isLooping = true;
    }

    private void OnTriggerStay(Collider other)
    {
        meshFilter.mesh = mesh[0];
    }

    private void OnTriggerExit(Collider other)
    {
        video.Stop();
        meshFilter.mesh = mesh[1];
    }

}

