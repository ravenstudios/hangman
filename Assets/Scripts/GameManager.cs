using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;



public class GameManager : MonoBehaviour
{
    [SerializeField]string word;
    public GameObject prefab;
    public Transform parent;
    public float gap;
    public SpriteRenderer sr;
    public List<char> letters = new List<char>();


    List<GameObject> letterObjects = new List<GameObject>();

    void Start()
    {

        word = word.ToUpper();

        for (int i = 0; i < word.Length; i++)
        {
            //char l = c.ToString];
            char c = word[i];
            
            letters.Add(c);

            Vector3 v = parent.transform.position + new Vector3(gap * i, 0, 0);

            GameObject displayLetter = Instantiate(prefab, v, Quaternion.identity) as GameObject;

            //Debug.Log(c);

            displayLetter.GetComponent<ShowLetter>().SetChar(c);

            if (c != ' ')
            {
                letterObjects.Add(displayLetter);
            }
            


            //ShowLetter script = displayLetter.GetComponent<ShowLetter>();
            //script.Show(unicode);

            
        }


    }

    public void Guess(char letter)
    {
        
        //click a letter to call this function

        //int i = word.IndexOf(letter);

        for (int i = 0; i <  letterObjects.Count; i++)
        {


            char l = letterObjects[i].GetComponent<ShowLetter>().GetChar();

            if (l == letter)
            {
                letterObjects[i].GetComponent<ShowLetter>().Show(letter);
            }
        }

    }
    //compare letters and if match show letter
}

        //if miss show part of hangman
    


    



