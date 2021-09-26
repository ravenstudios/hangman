using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLetter : MonoBehaviour
{
    [SerializeField] SpriteRenderer sb;

    string letter;

    [SerializeField] Sprite[] spriteArray;

    void Show()
    {
        sb.sprite = spriteArray[0];
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
