using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    private Vector3 dragOffset;
    Block myblock;
    [SerializeField] GameObject blockle;
    private void Awake()
    {
        myblock = blockle.GetComponent<Block>();
    }
    private void OnMouseDown()
      
    {
        dragOffset = transform.position - GetMousePos();
        myblock.now_selected();
        
    }
    private void OnMouseDrag()
    {
        transform.position = GetMousePos() + dragOffset;
        
    }
    Vector3 GetMousePos()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
    
    


}
