using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterMove : MonoBehaviour
{
    public float X { get; private set; }
    public float Y { get; private set; }
    public bool HasPushedEngineStart { get; private set; }

    void Update()
    {
        X = 0f;
        Y = 0f;
        HasPushedEngineStart = false;

        X = Input.GetAxis("Horizontal");
        Y = Input.GetAxis("Vertical");
        HasPushedEngineStart = Input.GetKeyDown(KeyCode.R);
    }
}