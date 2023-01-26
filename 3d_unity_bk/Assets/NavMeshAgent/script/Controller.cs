using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Controller : MonoBehaviour
{
    public float speed = 5.0f;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();   
    }

    public void Move(Vector3 dir)
    {
       agent.speed= speed;
       agent.SetDestination(dir);
    }

    
    void Update()
    {
        // ���콺 ���� ��ư(0) ������ 
        if(Input.GetMouseButtonDown(0)) 
        {
            RaycastHit hit; // ������ �浹�� ������Ʈ�� ��ü�� ���� ��������.

            Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
            // ī�޶�κ��� ��ũ�� ������ ���콺 �����͸� ���� ��ġ ������ ����.

            // �浹�� ��ü�� �ִٸ� move�Լ��� �Ű������� �浹�� ������Ʈ ��ġ�� ����(���Ѵ�� ���� ��)
            if(Physics.Raycast(ray, out hit, Mathf.Infinity)) 
            {
                Move(hit.point);
            }
        }
    }
}
