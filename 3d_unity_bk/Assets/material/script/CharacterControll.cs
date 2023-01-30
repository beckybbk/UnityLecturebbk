using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CharacterControll : MonoBehaviour
{
    bool condition;
    public float speed;

    Rigidbody rigid;
    Vector3 direction;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();  
    }

    
    private void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        // P=P0 +vt (등속이동)
        //transform.position = direction;
        //transform.Translate(direction * speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space) && condition==true)
        {
            rigid.AddForce(new Vector3(0, 200,0)); //AddForce: 객체에 일정한 힘을 가하는 함수.
            condition= false;
        }
    }

    private void FixedUpdate()
    {
        rigid.MovePosition
         (
            rigid.position + direction * speed * Time.deltaTime
            );
    }

    private void OnCollisionEnter(Collision collision)
    {

        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    private void OnCollisionStay(Collision collision)
    {
        condition= true;
    }

    private void OnCollisionExit(Collision collision)
    {
        condition= false;
        transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }
}
