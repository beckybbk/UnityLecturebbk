using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create : MonoBehaviour
{
    public GameObject prefab; // 내가 생성할 게임오브젝트(변수)
    public Transform[] randomPosition;


    public void GenericCreate()
    {
        delay.action();
        Instantiate // 게임 오브젝트를 생성하는 함수
            (
                prefab, // 생성해야 하는 게임 오브젝트 
                randomPosition[Random.Range(0,4)].position, // 생성되는 오브젝트의 위치
                Quaternion.identity // 회전 (회전하지 않음) 
            );

    }

   
    void Update()
    {
        
    }
}
