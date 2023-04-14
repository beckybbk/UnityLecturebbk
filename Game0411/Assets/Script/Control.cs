using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    // Awake : ��ũ��Ʈ "��Ȱ��ȭ �� ����"�� ���� ������Ʈ ������ �� �ѹ��� ȣ���ϴ� �̺�Ʈ �Լ�.
    private void Awake()
    {
        Debug.Log("Awake");
    }

    // OnEnable : ��ũ��Ʈ�� Ȱ��ȭ�϶� ȣ��Ǵ� �Լ�. (��ũ��Ʈ�� ��Ȱ,Ȱ���ϴ� Ƚ����ŭ)
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    // Start : ��ũ��Ʈ Ȱ�����·� ���� ������Ʈ�� �����Ǿ����� �� �ѹ��� ȣ��Ǵ� �̺�Ʈ �Լ�. 
    void Start()
    {
        Debug.Log("Start");
    }

    // FixedUpdate : �����Ӱ� ������� �ð����� (Timestep 0.02��) ���� ȣ��Ǵ� �Լ�.
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    // Update : ���� ������Ʈ Ȱ��ȭ ���·� �� �����Ӹ��� ȣ��Ǵ� �̺�Ʈ �Լ�.
    void Update()
    {
        // GetKey: Ű ������ ���� ȣ��Ǵ� �Լ�.
        // GetKeyDown : Ű�� �������� ȣ��Ǵ� �Լ�.
        // GetKeyUp: Ű�� ������ �� �� ȣ��Ǵ� �Լ�. 
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
    // LateUpdate : ���� ������Ʈ Ȱ��ȭ ���·� Update �Լ��� ȣ��Ǽ� ���� �������� ȣ��Ǵ� �Լ�
    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }
    // OnApplicationQuit: ���� ����� �ѹ��� ȣ��Ǵ� �Լ�. 
    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
    // OnDestroy: ���� ������Ʈ Ȱ��ȭ ���·� �ı��Ǿ����� ȣ��Ǵ� �̺�Ʈ �Լ� 
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
