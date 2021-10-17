using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowWord : MonoBehaviour
{
    string word;
    [SerializeField] GameObject prefab;
    List<char> letters = new List<char>();
    [SerializeField] float gap;

    List<GameObject> letterObjects = new List<GameObject>();

    
    void Start()
    {
        word = GetComponentInParent<WordGenerator>().GenerateWord();

        for (int i = 0; i < word.Length; i++)
        {
            
            char c = word[i];

            letters.Add(c);


            Vector3 v = new Vector3(i - 8, 3, 0);

            GameObject displayLetter = Instantiate(prefab, v, Quaternion.identity);
            displayLetter.transform.parent = gameObject.transform;
            
            displayLetter.GetComponentInParent<ShowLetter>().SetChar(c);

            if (c != ' ')
            {
                letterObjects.Add(displayLetter);
            }
        }
    }

    public string GetWord()
    {
        return word;
    }


    public List<GameObject>  GetLetters()
    {
        return letterObjects;
    }
}