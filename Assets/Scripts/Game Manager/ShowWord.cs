using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowWord : MonoBehaviour
{
    static string catagory, word;
    [SerializeField] GameObject dislplayLetterPrefab;
    [SerializeField] GameObject categoryLetterPrefab;
    [SerializeField] GameObject categoryWord1;
    [SerializeField] GameObject categoryWord2;
    static List<char> letters = new List<char>();
    [SerializeField] float gap;

    List<GameObject> letterObjects = new List<GameObject>();
    List<GameObject> catLetters = new List<GameObject>();

    void Awake()
    {
        SetUpGame();
    }


    public void SetUpGame()
    {
        //erase old list of letters

        letterObjects.ForEach(delegate(GameObject letter)
        {
            Destroy(letter);
        });

        letterObjects = new List<GameObject>();


        string[] result = GetComponentInParent<WordGenerator>().GenerateWord();
        //clear for new game
        catagory = "";
        catagory += result[0];

        catagory = catagory.ToUpper();

        word = result[1];
        
        //Debug.Log("get word function" + word);


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


        string cat = "CATEGORY";
        for (int i = 0; i < cat.Length; i++)
        {
            Vector3 v = new Vector3(i - 8, 6, 0);

            GameObject categoryLetter = Instantiate(categoryLetterPrefab, v, Quaternion.identity);
            categoryLetter.GetComponent<CategoryLetter>().SetChar(cat[i]);
            categoryLetter.transform.parent = categoryWord1.transform;
        }


         


        //Clear out list for new game
        catLetters.ForEach(delegate(GameObject catLetter) {
            Destroy(catLetter);
        });


        for (int i = 0; i < catagory.Length; i++)
        {
            char c = catagory[i];
            

            if (c != ' ')
            {
                Vector3 v = new Vector3(i - 8, 5, 0);

                GameObject categoryLetter = Instantiate(categoryLetterPrefab, v, Quaternion.identity);
                categoryLetter.GetComponent<CategoryLetter>().SetChar(catagory[i]);
                categoryLetter.transform.parent = categoryWord2.transform;
                catLetters.Add(categoryLetter);
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
