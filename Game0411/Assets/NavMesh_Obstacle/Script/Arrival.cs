using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Arrival : MonoBehaviour
{
    Vector3 direction = new Vector3(0, 0, 0);
    NavMeshAgent agent;
    public Transform arrive;

    void Start()
    {
        //print("direction�� ����: " + direction);

        //ValueFunction(direction);

        //print("direction�� ����: " + direction);

        //print(arrive.position);     //0,0,3
        //ReferenceFunction(arrive);
        //print(arrive.position);     //5,5,5

        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(arrive.position);
    }

    //����ü value Ÿ��
    public void ValueFunction(Vector3 vector)
    {
        vector = new Vector3(10, 10, 10);
    }

    // Ŭ���� reference Ÿ��
    public void ReferenceFunction(Transform tr)
    {
        tr.position=new Vector3(5,5,5);
    }
}
