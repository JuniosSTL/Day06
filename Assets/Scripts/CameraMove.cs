using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.3f;
    Vector3 currentVelocity;

    void Awake()
    {
        //target에 주인공의 transform 컴포넌트 찾아서 넣기
        //target = GameObject.Find("Body").transform;
        target = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void LateUpdate()
    {
        transform.position = Vector3.SmoothDamp(transform.position, target.position, ref currentVelocity, smoothTime);
        //transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * 4.0f);
        transform.rotation = Quaternion.Slerp(transform.rotation, target.rotation, Time.deltaTime * 4.0f);

        //현재 회전값을 오일러 회전방법 값을 가져오는거죠
        //Vector3 temp = transform.rotation.eulerAngles;

        //temp.y += 10;
        //Debug.Log(temp);

        //transform.rotation = Quaternion.Euler(temp);
    }
}
