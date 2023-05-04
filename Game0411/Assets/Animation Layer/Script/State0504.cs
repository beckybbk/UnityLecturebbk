using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class State0504 : MonoBehaviour
{
    private Animator animator;
    [SerializeField] Slider healthGauge;

    private void Start()
    {
        animator= GetComponent<Animator>(); 
    }

    // Update is called once per frame
    public void StateLayer(float health)
    {
        healthGauge.value = health;
        float Temporary = 1 - healthGauge.value;
        animator.SetLayerWeight(animator.GetLayerIndex("Other Layer"), Temporary);
    }
}
