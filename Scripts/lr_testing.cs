using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lr_testing : MonoBehaviour
{
    [SerializeField] private Vector3[] points;
    [SerializeField] private lr_LineController line;

    private void Start()
    {
        line.SetUpLine(points);
    }

}
