using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator= GetComponent<Animator>();
    }

    private void Update()
    {
        float vertical = Input.GetAxis("Vertical");     //-1~1 
        float horizontal = Input.GetAxis("Horizontal");

        // SetFloat : ("애니메이터 파라미터의 이름", 속성 값) 
        // vertical 값이 greater 0.1보다 크다 
        // vertical 값이 less -0.1보다 작다.
        animator.SetFloat("Vertical", vertical);
        animator.SetFloat("Horizontal", horizontal);
    }
}
