using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P38Move : MonoBehaviour
{
    public float moveSpeed = 20.0f;

    void Update()
    {
        transform.Translate(0, 0, moveSpeed * Time.deltaTime);
    }
}
