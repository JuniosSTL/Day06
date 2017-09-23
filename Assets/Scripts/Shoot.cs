using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    //미사일 프리팹
    public GameObject missilePrefab;
    //미사일 발사 위치
    public Transform[] shootPosition;
    public float shootTime = 0.1f;

    float totalTime = 0;

    private void Awake()
    {
        InvokeRepeating("MissileShoot", 0, shootTime);
    }

    void Update()
    {
        //totalTime = totalTime + Time.deltaTime;
        //if (shootTime <= totalTime) //지난간 시간이 발사 시간보다 크거나 같다.
        //{
        //    MissileShoot();
        //    totalTime = 0;
        //}
    }

    void MissileShoot()
    {
        for (int i = 0; i < shootPosition.Length; i++)
        {
            Instantiate(missilePrefab, shootPosition[i].position, shootPosition[i].rotation);
        }
    }
}
