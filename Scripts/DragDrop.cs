using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    // Start is called before the first frame update
    private bool is_selected = false;
    private Vector3 dragOffset;
    [SerializeField]
    public GameObject[] uis;
    public void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (is_selected)
            {

            hide_ui();
            is_selected = false;
            }
        }
    }
    private void OnMouseDown()
    {
        dragOffset = transform.position - GetMousePos();
        show_ui();
        is_selected = true;
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
    void show_ui() {
        for (int i = 0; i < uis.Length; i++)
        {
            uis[i].gameObject.SetActive(true);
        }
    }
    void hide_ui() {
        for (int i = 0; i < uis.Length; i++)
        {
            uis[i].gameObject.SetActive(false);
        }
    }
    


}
