using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    [SerializeField] Camera mainCamera;

   
    void Update()
    {
        float distance = Input.GetAxis("Mouse ScrollWheel") * -1 * 10;  // -1 : 

        mainCamera.fieldOfView = Mathf.Clamp     //Mathf.Clamp: if 대용, 깔끔
        (
            mainCamera.fieldOfView,         // 제안하고 싶은 속성
            20f,                            // 최소값,
            60f                             // 최대값
        );

        mainCamera.fieldOfView +=distance;
    }
}
