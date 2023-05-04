using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BilliardBall : MonoBehaviour
{
    private Vector3 direction;
    [SerializeField] float speed = 1.0f;
    [SerializeField] Rigidbody rigidbody;


    
    private void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rigidbody.AddForce  // AddForce: rigidbody�� ����� �Լ�.
            (
                direction * speed,      //����� �ӵ�
                ForceMode.Acceleration  //���� �ִ� ���� : ������ �����ϰ� �������� �� ���ϴ� ���.
            );
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Pillar"))
        {
            var result = Vector3.Reflect
                (
                    transform.position.normalized,
                    collision.contacts[0].normal
                );

            rigidbody.velocity = result * Mathf.Max(speed, 0f);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.CompareTag("Billiard Ball"))
        {
            rigidbody.AddTorque
                (
                    Vector3.up * speed,     //ȸ�� ��� �ӵ�
                    ForceMode.Impulse       //������ ������ ���·� �������� ���� ����ϴ� ����(ȸ��)
                );
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pillar"))
        {
            int randomMode = Random.Range(0, 3);
            rigidbody.interpolation = (RigidbodyInterpolation)randomMode; // ��������ȯ
        }
    }
}
