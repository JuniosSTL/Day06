using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMove : MonoBehaviour
{
    public float moveSpeed = 30.0f;

    void Awake()
    {
        Destroy(gameObject, 3.0f); 
    }

    void Update()
    {
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }
}
