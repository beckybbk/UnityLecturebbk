using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour
{
    
    void Start()
    {
        Destroy(gameObject, Random.Range(1,5));  // ���� ������Ʈ�� �ı��ϴ� �Լ�
    }

    
}
