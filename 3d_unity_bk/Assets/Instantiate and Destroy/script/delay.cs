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
        action = ()=> Function();
        button= GetComponent<Button>();

    }

    void Function()
    {
        isDelay = false;
    }

    
    void Update()
    {
        if(isDelay==false)
        {
            button.interactable= false; // 버튼 비활성화 
            currentTime-= Time.deltaTime; 
            button.image.fillAmount = currentTime / fixedTime;

            if(currentTime<=0)
            {
                isDelay= true;
                button.interactable= true;
                button.image.fillAmount = currentTime = fixedTime;

            }
        }
    }
}
