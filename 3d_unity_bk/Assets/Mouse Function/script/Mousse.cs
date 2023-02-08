using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Mousse : MonoBehaviour
{
    bool power = false;
    private RaycastHit hit;

    [SerializeField] Rigidbody rigid;
    [SerializeField] GameObject state;
    [SerializeField] VideoPlayer video;
    [SerializeField] LayerMask layerMask;


    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Input.GetButtonDown("Fire1"))
        {
            if(Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask)) 
            {
                power = !power;

                if(power==true)
                    video.Play();
                else
                    video.Stop();

            }

        }
    }
}
