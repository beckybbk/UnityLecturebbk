using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parallax : MonoBehaviour
{
    [SerializeField] Rect rect;     //SerializeField: private 변수를 inspector(외부)에 공개시켜주는 attribute.  
    [SerializeField] RawImage rawImage;
    [SerializeField] float speed = 0.25f;
   
    void Update()
    {
        rect = rawImage.uvRect;
        rect.x += Time.deltaTime * speed;   //가로로 움직이면 x, 세로로 움직이면 y
        rawImage.uvRect = rect;
    }
}
