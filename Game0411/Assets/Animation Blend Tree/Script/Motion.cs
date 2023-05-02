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

        // SetFloat : ("�ִϸ����� �Ķ������ �̸�", �Ӽ� ��) 
        // vertical ���� greater 0.1���� ũ�� 
        // vertical ���� less -0.1���� �۴�.
        animator.SetFloat("Vertical", vertical);
        animator.SetFloat("Horizontal", horizontal);
    }
}
