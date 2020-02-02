using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    public float hSpeed;
    public float vSpeed;

    void Start()
    {
        hSpeed = 2.0f;
        vSpeed = 2.0f;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float v = vSpeed * Input.GetAxis("Mouse X");
            float h = hSpeed * Input.GetAxis("Mouse Y");

            transform.Rotate(v, h, 0);
        }
    }
}
