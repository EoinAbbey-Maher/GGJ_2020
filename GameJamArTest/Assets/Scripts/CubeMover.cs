using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    public void xAxis(int angle)
    {
        gameObject.transform.Rotate(angle, 0, 0);
    }

    public void yAxis(int angle)
    {
        gameObject.transform.Rotate(0, angle, 0);
    }

    public void zAxis(int angle)
    {
        gameObject.transform.Rotate(0, 0, angle);
    }
}
