using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Monster
{
    public Monster()
    {
        Debug.Log("Monster�� �¾���.");

    }
}
public class Test : MonoBehaviour
{
    public int Value = 100;

    
    void Start()
    {
        Debug.Log(Value);
        Monster monster = new Monster();

    }

    
    void Update()
    {
        
    }
}
