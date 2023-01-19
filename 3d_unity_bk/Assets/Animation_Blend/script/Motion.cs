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

   
    void Update()
    {
        // Input.GetAxis = -1~0~1 사이의 값을 반환. 
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        animator.SetFloat("Vertical", vertical);
        animator.SetFloat("Horizontal", horizontal);

    }
}
