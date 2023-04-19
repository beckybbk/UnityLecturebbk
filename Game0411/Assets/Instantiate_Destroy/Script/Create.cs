using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Create : MonoBehaviour
{
    public Button button;
    public GameObject prefab;

    private bool active = true;
    private float fixedTime = 5f;
    private float currentTime = 5f;

public void CreateGeneric()
    {
        active= false;
        Instantiate         // 게임 오브젝트를 생성하는 함수. 
            (prefab,                    // 생성할 게임 오브젝트
            new Vector3(0,-1.25f,0),    // 생성되는 위치 값
            prefab.transform.rotation   // 생성되는 회전 값
            ).AddComponent<Delete>();
            
    }
    
    
    private void Update()
    {
        //Debug.Log(Time.deltaTime);


        if(active ==false) 
        { 
            button.interactable = false;        //버튼 오브젝트 비활성화
            currentTime -= Time.deltaTime;      //currentTime에서 한 프레임당 실행되는 시간을 뺌.
            button.image.fillAmount = currentTime / fixedTime;

            if(currentTime <=0)
            {
                active= true;
                button.interactable = true;
                button.image.fillAmount = currentTime = fixedTime;
            }
        }
    }
}
