using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    string word = "cat";
    public GameObject prefab;
    public Transform parent;
    public float gap;
    public SpriteRenderer sr;



    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        
        foreach (var c in word)
        {
            Vector3 v = parent.transform.position + new Vector3(gap * i, 0, 0);
            Instantiate(prefab, v, Quaternion.identity);
            i++;
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
