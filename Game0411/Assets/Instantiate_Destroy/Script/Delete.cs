using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    int random = Random.Range(1, 5);    // 1~5������ ���� ��ȯ��.

    void Start()
    {
        Destroy(gameObject, random);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
