using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLetter : MonoBehaviour
{
    [SerializeField] SpriteRenderer sr;
    [SerializeField] Sprite[] spriteArray;

    char c;
    

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }


    private void Update()
    {
        if (c == ' ')
        {
            sr.sprite = null;
        }
    }
    

    public char GetChar()
    {
        return c;
    }


    public void SetChar(char chr)
    {
        c = chr;
    }


    public void Show(char c)
    {
        if (c != ' ')
        {
            sr.sprite = spriteArray[c - 65];
        }
        
    }


}


