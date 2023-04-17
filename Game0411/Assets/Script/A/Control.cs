using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    // Awake : 스크립트 "비활성화 된 상태"로 게임 오브젝트 생성시 단 한번만 호출하는 이벤트 함수.
    private void Awake()
    {
        Debug.Log("Awake");
    }

    // OnEnable : 스크립트가 활성화일때 호출되는 함수. (스크립트를 비활,활성하는 횟수만큼)
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    // Start : 스크립트 활성상태로 게임 오브젝트가 생성되었을때 단 한번만 호출되는 이벤트 함수. 
    void Start()
    {
        Debug.Log("Start");
    }

    // FixedUpdate : 프레임과 상관없이 시간기준 (Timestep 0.02초) 으로 호출되는 함수.
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    // Update : 게임 오브젝트 활성화 상태로 매 프레임마다 호출되는 이벤트 함수.
    void Update()
    {
        // GetKey: 키 누르는 동안 호출되는 함수.
        // GetKeyDown : 키를 눌렀을때 호출되는 함수.
        // GetKeyUp: 키를 눌렀다 뗀 후 호출되는 함수. 
        if (Input.GetKey(KeyCode.W))
        {   // Vector3.forward (0,0,1)
            transform.position = transform.position + Vector3.forward * 5f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {   //Vector3.back (0,0,-1)
            transform.position = transform.position + Vector3.back * 10f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + Vector3.left * 5f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + Vector3.right * 5f * Time.deltaTime;
        }

        Debug.Log("Update");
    }
    // LateUpdate : 게임 오브젝트 활성화 상태로 Update 함수가 호출되서 나서 마지막에 호출되는 함수
    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }
    // OnApplicationQuit: 게임 종료시 한번만 호출되는 함수. 
    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
    // OnDestroy: 게임 오브젝트 활성화 상태로 파괴되었을때 호출되는 이벤트 함수 
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
