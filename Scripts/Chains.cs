using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chains : MonoBehaviour
{
    [SerializeField] public Vector3[] points;
    [SerializeField] private lr_LineController line;
    [SerializeField] private Transform cube;
    public bool allow_conn = false;
    public int connected = 0;
    private bool do_draw;
    public GameObject prev_block;
    public GameObject next_block;
    private void Start()
    {
        points = new Vector3[2];
        cube = gameObject.transform.GetChild(2);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1)){
            if (connected!=2)
            {
                if (gameObject.GetComponent<Block>().is_selected)
                {
                    do_draw = true;
                }
            }
            else
            {
            }
        }
        if (do_draw) {
            if (gameObject.GetComponent<Block>().is_selected)
            {

            points[0] = cube.position;
            }
            if (!allow_conn)
            {
            points[1] = GetMousePos();
            }
            else
            {
                points[1] = prev_block.transform.position;
            }
            line.gameObject.SetActive(true);
            line.SetUpLine(points);
            
        }
        
        

    }
    private void OnMouseDown()
    {
        
    }
    Vector3 GetMousePos()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
    public void connect_me(GameObject go)
    {
        prev_block = go;
        allow_conn = true;
    }

}
