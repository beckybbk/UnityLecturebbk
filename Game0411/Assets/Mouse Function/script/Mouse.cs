using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Mouse : MonoBehaviour
{
   bool power = false;
    private RaycastHit hit;

    [SerializeField] Rigidbody rigid;
    [SerializeField] GameObject state;
    [SerializeField] VideoPlayer video;
    [SerializeField] LayerMask layerMask;

    
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if(Input.GetButtonDown("Fire1"))
        {
            if(Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask)) 
            {
                power = !power;

                if(power == true)
                    video.Play();
                else
                    video.Stop();
            }
        }

    }
    //마우스로 오브젝트를 선택했을때 호출되는 함수
    private void OnMouseDown()
    {
        state.SetActive(true);
        rigid.isKinematic= true;
    }
    //마우스로 오브젝트를 드래그했을때 호출되는 함수
    private void OnMouseDrag() 
    {
        Vector3 mousePosition = new Vector3
            (
                Input.mousePosition.x,
                Input.mousePosition.y,
                Camera.main.WorldToScreenPoint(gameObject.transform.position).z
            );
        Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position= objectPosition;
    }

    // 마우스를 뗏을때 호출되는 함수.
    private void OnMouseUp()
    {
        state.SetActive(false);
        rigid.isKinematic= false;
    }
}
