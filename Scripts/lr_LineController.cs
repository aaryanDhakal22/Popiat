using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lr_LineController : MonoBehaviour
{
    private LineRenderer lr;
    private Vector3[] points;

    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }
    public void SetUpLine(Vector3[] points)
    {
        lr.positionCount = points.Length;
        this.points = points;
    }
    private void Update()
    {
        for (int i = 0; i < points.Length; i++)
        {
            lr.SetPosition(i, points[i]);
        }
    }
}

