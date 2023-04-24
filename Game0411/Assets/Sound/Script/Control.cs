using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float speed = 5.0f;
    private CharacterController control;


    void Start()
    {
        control= GetComponent<CharacterController>();
    }

    // Update is called once per frame
    private void Update()
    {
        float x = Input.GetAxis("Horizontal");      // A, D, 왼쪽, 오른쪽키: -1에서 1 사이의 값을 반환하는 함수.
        float z = Input.GetAxis("Vertical");        // W, S, 위, 아래쪽키: -1에서 1 사이의 값을 반환하는 함수.

        Vector3 direction = new Vector3(x,0,z).normalized;

        control.SimpleMove(direction*speed);        // SimpleMove: 중력계산되는 이동함수.
    }
}
