using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour
{
    [SerializeField] GameObject myPrefab;
    [SerializeField] Sprite[] spriteArray;
    [SerializeField] float xOffset = 50;
    [SerializeField] float yOffset = 100;
    [SerializeField] Transform parentPos;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = new Vector3(0, 0, 0);
        
        
        

        for (int i = 0; i < 26; i++)
        {
            if (i < 10)
            {
                pos = transform.position + new Vector3(xOffset * i, yOffset * 1, 1);
            }

            else if (i > 9 && i < 19)
            {
                pos = transform.position + new Vector3(xOffset * i - 10,yOffset * 2, 1);
            }

            else if (i > 18)
            {
                pos = transform.position + new Vector3(xOffset * i - 20,yOffset * 3, 1);
            }


            GameObject obj = Instantiate(myPrefab, pos, Quaternion.identity);
            obj.GetComponent<SpriteRenderer>().sprite = spriteArray[i];
            //obj.GetComponent<Transform>().localScale = new Vector3(2, 2, 1);
            char c = (char)(65 + i);
            Debug.Log(obj);
            obj.GetComponent<ClickLetter>().SetChar(c);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
