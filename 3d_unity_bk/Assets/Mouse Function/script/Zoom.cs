using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    [SerializeField] Camera mainCamera;

   
    void Update()
    {
        float distance = Input.GetAxis("Mouse ScrollWheel") * -1 * 10;
        mainCamera.fieldOfView = Mathf.Clamp // Mathf.Clamp �� Ư���� ���� �ּҰ��� �ִ밪�� ���̿� �ΰ� �����ϴ� �Լ�. 
            (
                mainCamera.fieldOfView,
                20.0f,
                60.0f
            );

        mainCamera.fieldOfView += distance;  
    }
}
