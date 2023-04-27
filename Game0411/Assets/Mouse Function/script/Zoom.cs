using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    [SerializeField] Camera mainCamera;

   
    void Update()
    {
        float distance = Input.GetAxis("Mouse ScrollWheel") * -1 * 10;  // -1 : 

        mainCamera.fieldOfView = Mathf.Clamp     //Mathf.Clamp: if ���, ���
        (
            mainCamera.fieldOfView,         // �����ϰ� ���� �Ӽ�
            20f,                            // �ּҰ�,
            60f                             // �ִ밪
        );

        mainCamera.fieldOfView +=distance;
    }
}
