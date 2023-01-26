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
        // 마우스 왼쪽 버튼(0) 누를때 
        if(Input.GetMouseButtonDown(0)) 
        {
            RaycastHit hit; // 광선과 충돌한 오브젝트의 물체에 대한 정보저장.

            Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
            // 카메라로부터 스크린 공간의 마우스 포인터를 통해 위치 정보를 설정.

            // 충돌한 물체가 있다면 move함수의 매개변수에 충돌한 오브젝트 위치를 설정(무한대로 광선 쏨)
            if(Physics.Raycast(ray, out hit, Mathf.Infinity)) 
            {
                Move(hit.point);
            }
        }
    }
}
