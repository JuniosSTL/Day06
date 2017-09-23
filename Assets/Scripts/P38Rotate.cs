using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P38Rotate : MonoBehaviour
{
    public float angularSpeed = 45.0f;

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Rotate(v * angularSpeed * Time.deltaTime,
            0, 
            -h * angularSpeed * Time.deltaTime);
    }
}
