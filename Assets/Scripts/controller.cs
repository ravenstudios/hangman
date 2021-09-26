using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class controller : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string c;

    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    string OnMouseDown()
    {
        rb.isKinematic = false;
        Debug.Log("click:  " + c);
        return c;
    }
}