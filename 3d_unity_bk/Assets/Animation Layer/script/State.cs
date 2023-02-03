using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class State : MonoBehaviour
{
    private Animator animator;
    [SerializeField] Slider HealthGuage;
    void Start()
    {
        animator = GetComponent<Animator>();    
    }

    public void StateLayer(float health)
    {
        HealthGuage.value= health;
        float temporary=1-HealthGuage.value;
        animator.SetLayerWeight(animator.GetLayerIndex("Other Layer"), temporary);


    }
}
