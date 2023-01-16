using UnityEngine;
using UnityEngine.UI;
using System;
using System.Runtime.CompilerServices;



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

    public int[] count;
    public int[] data = new int[3];
    
    void Start()
    {
        Debug.Log(Value);
        Monster monster = new Monster();

        transform.position = new Vector3(0,transform.position.y,1);

        foreach(var element in data)
        {
            Debug.Log(element);
        }

        foreach (var element in count)
        {
            Debug.Log(element);
        }

    }

    
    void Update()
    {
        //GetKeyDown Ű�� ������ ��, GetKeyUp Ű���� ���� �� �� ����. 
        // GetKey : Ű�� ������ ������ (����, ��� �̵� ����) 
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("�����̽� ������");
        }

        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        //}

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1,0,0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 1);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -1);
        }
    }
}
