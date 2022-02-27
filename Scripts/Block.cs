using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block : MonoBehaviour
{

    [SerializeField]
    public GameObject[] uis;
    public string data;
    public string hash;
    public int prev_hash;
    public bool is_selected = false;
    GameObject cubemanager;
    [SerializeField] public InputField data_field;
    public Hashtable hash_tabs = new Hashtable()
    {
        {'1','7'},{'2','4'},{'3','8'},{'4','9'},{'5','3'},{'6', '6'},{'7','5' },{'8','1'},{'9','0' },{'0','2' }
    };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
                is_selected = false;
                
        }
        
        if (is_selected)
        {
            show_ui();
            gameObject.tag = "selected";
            cubemanager = GameObject.FindGameObjectWithTag("manager");
            cubemanager.GetComponent<CubeManger>().unselect_all(gameObject);
        }
        else
        {
            hide_ui();
            gameObject.tag = "unselected";
        }

    }
    string hash_gen(char hashes)
    {
        //print(hashes);
        string result = hash_tabs[hashes].ToString();
        return result;
    }
    public void setData()
    {
        string new_hash  = "";
        data = data_field.text;
        foreach (char c in data)
        {
            new_hash+=hash_gen(c);
        }
        hash = new_hash;
        print(new_hash);
    }
    void show_ui()
    {
        for (int i = 0; i < uis.Length; i++)
        {
            uis[i].gameObject.SetActive(true);
        }
    }
    void hide_ui()
    {
        for (int i = 0; i < uis.Length; i++)
        {
            uis[i].gameObject.SetActive(false);
        }
    }
    public void now_selected()
    {
        is_selected = true;
        
    }
}
