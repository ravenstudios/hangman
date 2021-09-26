using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickLetter : MonoBehaviour
{
    GameObject gameManager;

    [SerializeField] char c;

    Rigidbody2D rb;

    void Awake()
    {
        
        rb = GetComponent<Rigidbody2D>();
        gameManager = GameObject.Find("GameManager");
    }

    public void SetChar(char chr)
    {
        c = chr;
    }


    public char GetChar()
    {
        return c;
    }


    void OnMouseDown()
    {

        Debug.Log("mouse down: " + GetChar());
        gameManager.GetComponent<GameManager>().Guess(c);
        
        //rb.isKinematic = false;
        
        
    }
}