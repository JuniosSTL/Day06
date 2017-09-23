using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform body;

    void Awake()
    {
        //body에 주인공의 transform 컴포넌트 찾아서 넣기
        //body = GameObject.Find("Body").transform;
        body = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void LateUpdate()
    {
        //카메라지지 위치는 body 똑같은 위치에 있다.
        transform.position = body.position;
    }
}
