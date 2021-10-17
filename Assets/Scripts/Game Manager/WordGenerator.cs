using UnityEngine;
using System.Collections;
using System;
using Random = UnityEngine.Random;


public class WordGenerator : MonoBehaviour
{

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

    string word;



    public string GenerateWord()
    {
        //adds all lists in one array 
        string[][] words = { plants, animales, witchCraft, witchyTools, easy };
        int randCatagoryndex = Random.Range(0, words.Length);

        string[] randomCatogory = words[randCatagoryndex];
        int randWordIndex = Random.Range(0, randomCatogory.Length);
        word = randomCatogory[randWordIndex];
        word = word.ToUpper();
        
        word = "CATT";
        return word;
    }
}
