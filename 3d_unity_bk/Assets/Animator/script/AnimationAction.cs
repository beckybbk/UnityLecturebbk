using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationAction : MonoBehaviour
{
    public Animator animator;

    public void FlipKick()
    {
        animator.Play("Flip Kick"); // Play : �ִϸ��̼� �����Լ� 
    }

    public void RunnigBackward()
    {
        animator.Play("Running Backward");
    }
   
}
