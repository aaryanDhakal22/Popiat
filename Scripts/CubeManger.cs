using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class CubeManger : MonoBehaviour
{
    [SerializeField]
    GameObject cube;
    private GameObject[] cubecollection = new GameObject[10];
    private int size_go = 0;
    private GameObject[] unselected;
    private GameObject[] selected;
    private GameObject for_del;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per how 
    void Update()
    {
        if (Input.GetKeyDown("delete"))
        {
            for_del = GameObject.FindGameObjectWithTag("selected");
            Destroy(for_del);
        }
    }
    public void addCube()
    {
        Instantiate(cube);
        cube.transform.position = Vector3.zero;
        //cubecollection.Append()
        cubecollection[size_go] = cube.gameObject; 
        print(cube.GetInstanceID());
        size_go++;
    }
    public void unselect_all(GameObject go)
    {
        selected = GameObject.FindGameObjectsWithTag("selected");
        foreach (GameObject cube in selected)
        {
            if (cube.GetInstanceID() != go.GetInstanceID())
            {
                cube.GetComponent<Block>().is_selected = false;
                cube.tag = "unselected";
            }
        }

    }

}
