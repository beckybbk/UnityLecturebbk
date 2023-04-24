using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Controller_Nav : MonoBehaviour
{
    public int count;
    public Transform[] point;
    public NavMeshAgent navMeshAgent;

    void Start()
    {
        InvokeRepeating("Move", 1, 5f);     // Move: 실행할 함수 이름, 1 : 몇 초 뒤 실행, 5: 몇 초 마다 실행 
    }

    public void Move()
    {
        if(navMeshAgent.velocity==Vector3.zero) 
        { 
            if(point.Length<=count) 
            {
                count = 0;
            }

            navMeshAgent.SetDestination(point[count++].position);
        }
   
    }

}
