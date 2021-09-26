using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLetter : MonoBehaviour
{
    [SerializeField] SpriteRenderer sb;

    public char c;

    private void Awake()
    {
        sb = GetComponent<SpriteRenderer>();
        
        
        
    }


    private void Update()
    {
        if (c == ' ')
        {
            sb.sprite = null;
        }
    }
    string letter;

    [SerializeField] Sprite[] spriteArray;


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
        
        sb.sprite = spriteArray[c - 65];
    }


}


