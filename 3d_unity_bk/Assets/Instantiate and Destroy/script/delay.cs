using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;



public class delay : MonoBehaviour
{
    private Button button;
    public static Action action;

    private bool isDelay = true;
    private float fixedTime = 5f;
    private float currentTime = 5f;


    void Start()
    {
        action = ()=> isDelay= false;
        button= GetComponent<Button>();

    }

    
    void Update()
    {
        
    }
}
