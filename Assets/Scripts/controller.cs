using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class controller : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string c;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string OnMouseDown()
    {
        Debug.Log("click:  " + c);
        return c;
    }
}
