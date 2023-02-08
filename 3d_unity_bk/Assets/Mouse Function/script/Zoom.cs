using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    [SerializeField] Camera mainCamera;

   
    void Update()
    {
        float distance = Input.GetAxis("Mouse ScrollWheel") * -1 * 10;
        mainCamera.fieldOfView = Mathf.Clamp // Mathf.Clamp 는 특정한 값을 최소값과 최대값을 사이에 두고 제한하는 함수. 
            (
                mainCamera.fieldOfView,
                20.0f,
                60.0f
            );

        mainCamera.fieldOfView += distance;  
    }
}
