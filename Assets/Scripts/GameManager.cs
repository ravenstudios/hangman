using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    [SerializeField] string catagory;
    public GameObject prefab;
    public Transform parent;
    public float gap;
    public SpriteRenderer sr;
    public List<char> letters = new List<char>();

    //Plants
    string[] plants = { "Belladonna", "Sage", "Lavender", "Rosemary", "Mugwort" };

    //Animals
    string[] animales = { "Bat", "Owl", "Toad", "Spider", "Black Cat" };

    //Witch Craft
    string[] witchCraft = { "Occult", "Potion", "Hex,", "Enchant", "Magic" };

    //Witchy Tools
    string[] witchyTools = { "Cauldron", "Broomstick", "Eyeballs", "Eye of Newt", "Spell Book" };

    //Easy
    string[] easy = { "Hallloween", "Pumpkin", "Orange", "Black", "Witch", "Candy", "Trick or Treat", "October" };



    List<GameObject> letterObjects = new List<GameObject>();

    void Start()
    {
        string[][] words = { plants, animales, witchCraft, witchyTools, easy };

        int catagoryIndex = Array.IndexOf(words, catagory);
        int randCatagoryndex = Random.Range(0, words.Length);

        string[] randomCatogory = words[randCatagoryndex];
        int randWordIndex = Random.Range(0, randomCatogory.Length);
        string word = randomCatogory[randWordIndex];
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

        for (int i = 0; i < letterObjects.Count; i++)
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







