using UnityEngine;
using System.Collections;
using System;
using Random = UnityEngine.Random;


public class WordGenerator : MonoBehaviour
{

    //Plants
    string[] plants = { "Belladonna", "Sage", "Lavender", "Rosemary", "Mugwort" };

    //Animals
    string[] animals = { "Bat", "Owl", "Toad", "Spider", "Black Cat" };

    //Witch Craft
    string[] witchCraft = { "Occult", "Potion", "Hex", "Enchant", "Magic" };

    //Witchy Tools
    string[] witchyTools = { "Cauldron", "Broomstick", "Eyeballs", "Eye of Newt", "Spell Book" };

    //Easy
    string[] easy = { "Halloween", "Pumpkin", "Orange", "Black", "Witch", "Candy", "Trick or Treat", "October" };

    string[] catagories = { "Plants", "Animals", "Witch Craft", "Witchy Tools", "Easy"};

    string word;

    string category;

    public string[] GenerateWord()
    {
        //adds all lists in one array 
        string[][] words = { plants, animals, witchCraft, witchyTools, easy };
        int randCatagoryndex = Random.Range(0, words.Length);
        category = catagories[randCatagoryndex];
        string[] randomCatogory = words[randCatagoryndex];
        int randWordIndex = Random.Range(0, randomCatogory.Length);
        word = randomCatogory[randWordIndex];
        word = randomCatogory[randWordIndex];
        word = word.ToUpper();

        Debug.Log(word);
        //Debug.Log(category);
        string[] result = {category, word };
        return result;
        
    }
}
