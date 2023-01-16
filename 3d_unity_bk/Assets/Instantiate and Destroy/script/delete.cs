using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour
{
    
    void Start()
    {
        Destroy(gameObject, Random.Range(1,5));  // 게임 오브젝트를 파괴하는 함수
    }

    
}
