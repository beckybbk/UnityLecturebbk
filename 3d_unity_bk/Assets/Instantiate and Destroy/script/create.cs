using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create : MonoBehaviour
{
    public GameObject prefab; // ���� ������ ���ӿ�����Ʈ(����)
    public Transform[] randomPosition;


    public void GenericCreate()
    {
        delay.action();
        Instantiate // ���� ������Ʈ�� �����ϴ� �Լ�
            (
                prefab, // �����ؾ� �ϴ� ���� ������Ʈ 
                randomPosition[Random.Range(0,4)].position, // �����Ǵ� ������Ʈ�� ��ġ
                Quaternion.identity // ȸ�� (ȸ������ ����) 
            );

    }

   
    void Update()
    {
        
    }
}
