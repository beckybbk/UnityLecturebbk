using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    bool [] condition = new bool[3];
    public GameObject[] lightEffect;
    

    void Start()
    {
        for(int i=0; i<3; i++) 
        {
            condition[i] = false;   
        }
    }

    public void LightSetting(int number)
    {
        condition[number] = !condition[number];
        lightEffect[number].SetActive(condition[number]);
    }

    
    void Update()
    {
        
    }
}
