using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public float moveSpeed = 4.0f;
    public float angularSpeed = 360.0f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal"); //가상 조이스틱
        float v = Input.GetAxis("Vertical");

        transform.Translate(0, v * moveSpeed * Time.deltaTime, 0);
        transform.Rotate(0, 0, -h * angularSpeed * Time.deltaTime);
    }
}
