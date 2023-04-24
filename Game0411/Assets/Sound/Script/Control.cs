using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float speed = 5.0f;
    private CharacterController control;


    void Start()
    {
        control= GetComponent<CharacterController>();
    }

    // Update is called once per frame
    private void Update()
    {
        float x = Input.GetAxis("Horizontal");      // A, D, ����, ������Ű: -1���� 1 ������ ���� ��ȯ�ϴ� �Լ�.
        float z = Input.GetAxis("Vertical");        // W, S, ��, �Ʒ���Ű: -1���� 1 ������ ���� ��ȯ�ϴ� �Լ�.

        Vector3 direction = new Vector3(x,0,z).normalized;

        control.SimpleMove(direction*speed);        // SimpleMove: �߷°��Ǵ� �̵��Լ�.
    }
}
