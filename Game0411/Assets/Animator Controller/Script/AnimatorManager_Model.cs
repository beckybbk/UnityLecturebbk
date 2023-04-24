using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AnimatorController
{
    public class AnimatorManager_Model : MonoBehaviour
    {
        public Slider slider;
        public Animator animator;

        public void StartAnimation(string name)
        {
            animator.CrossFade(name, slider.value);     // CrossFade �ϴ� ������ slider�� �ϰڴ�.
        }
    }
}
