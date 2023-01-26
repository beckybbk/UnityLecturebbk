using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public Animator animator;
    public GameObject window;

    void Update()
    {
        // 애니메이터 컨트롤러에서 현재 애니메이터의 상태 이름이 "Close"라면
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("Close"))
        {
            if(animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
            {
                window.SetActive(false);
            }
        }
    }

    public void Close()
    {
        animator.SetTrigger("Close");
    }

    public void PopUpOpen()
    {
        window.SetActive(true);
    }
}
