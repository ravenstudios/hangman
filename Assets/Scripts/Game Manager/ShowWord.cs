using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowWord : MonoBehaviour
{
    string catagory, word;
    [SerializeField] GameObject dislplayLetterPrefab;
    [SerializeField] GameObject categoryLetterPrefab;
    [SerializeField] GameObject category;
    List<char> letters = new List<char>();
    [SerializeField] float gap;

    List<GameObject> letterObjects = new List<GameObject>();

    
    void Start()
    {
        catagory += "CATEGORY ";
        catagory += GetComponentInParent<WordGenerator>().GenerateWord()[0];

        catagory = catagory.ToUpper();

        word = GetComponentInParent<WordGenerator>().GenerateWord()[1];



        for (int i = 0; i < word.Length; i++)
        {
            
            char c = word[i];

            letters.Add(c);


            Vector3 v = new Vector3(i - 7, 3, 0);

            GameObject displayLetter = Instantiate(dislplayLetterPrefab, v, Quaternion.identity);
            displayLetter.transform.parent = gameObject.transform;
            
            displayLetter.GetComponentInParent<ShowLetter>().SetChar(c);

            if (c != ' ')
            {
                letterObjects.Add(displayLetter);
            }
        }


        for (int i = 0; i < catagory.Length; i++)
        {
            char c = catagory[i];
            

            if (c != ' ')
            {
                Vector3 v = new Vector3(i - 8, 6, 0);

                GameObject categoryLetter = Instantiate(categoryLetterPrefab, v, Quaternion.identity);
                categoryLetter.GetComponent<CategoryLetter>().SetChar(catagory[i]);
                categoryLetter.transform.parent = category.transform;
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
