using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    [SerializeField] int distance = 3;

    void Update()
    {
        transform.position = Vector3.MoveTowards
            (
                transform.position,
                new Vector3(distance, 1, 0),
                1 * Time.deltaTime
            );

        if(transform.position.x>=3)
        {
            distance= -3;

        }

        else if(transform.position.x<=-3) 
        { 
            distance= 3;
        }
    }
}
