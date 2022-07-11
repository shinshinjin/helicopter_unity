using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    Rigidbody rigid;
    public float MissileSpeed = 8f;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Vector3 mis = Vector3.up;
        //transform.position += mis * MissileSpeed * Time.deltaTime;
    }
}
