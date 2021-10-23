using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CategoryLetter : MonoBehaviour
{

    [SerializeField] List<Sprite> sprites;
    SpriteRenderer sr;
    char ch = 'A';

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = sprites[ch - 65];
    }

    public void SetChar(char c)
    {
        ch = c;
    }
}
