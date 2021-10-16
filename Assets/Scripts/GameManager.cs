using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using System.Linq;
using System;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    [SerializeField] string catagory;
    [SerializeField] GameObject prefab;
    [SerializeField] Transform parent;
    [SerializeField] float gap;
    [SerializeField] SpriteRenderer sr;
    [SerializeField] List<char> letters = new List<char>();
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip[] sounds;
    [SerializeField] float soundFXLevel;
    [SerializeField] int guessesLeft;
    [SerializeField] GameObject health;
    [SerializeField] Slider soundFXLevelSlider;

    int numberOfgusses;

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

    List<GameObject> letterObjects = new List<GameObject>();

    void Start()
    {

        health.GetComponent<Health>().Show(guessesLeft);
        string[][] words = { plants, animales, witchCraft, witchyTools, easy };

        int catagoryIndex = Array.IndexOf(words, catagory);
        int randCatagoryndex = Random.Range(0, words.Length);

        string[] randomCatogory = words[randCatagoryndex];
        int randWordIndex = Random.Range(0, randomCatogory.Length);
        word = randomCatogory[randWordIndex];
        word = word.ToUpper();

        word = "CAT";
        audioSource.Play();

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
        }
    }

    public void Guess(char letter)
    {
        for (int i = 0; i < letterObjects.Count; i++)
        {
            char l = letterObjects[i].GetComponent<ShowLetter>().GetChar();

            if (l == letter)
            {
                letterObjects[i].GetComponent<ShowLetter>().Show(letter);
                
                audioSource.PlayOneShot(sounds[1], soundFXLevel);//right awnser
                numberOfgusses ++;

                if (numberOfgusses == word.Length)
                {
                    audioSource.Stop();
                    audioSource.PlayOneShot(sounds[2], soundFXLevel);//winner
                    return;
                }

                return;

            }
        }

        WrongGuess();

        

        if (guessesLeft == 0)
        {
            audioSource.Stop();
            audioSource.PlayOneShot(sounds[0], soundFXLevel);//game over
            return;
        }

    }


    void WrongGuess()
    {
        guessesLeft--;
        health.GetComponent<Health>().Show(guessesLeft);
        audioSource.PlayOneShot(sounds[3], soundFXLevel);//wrong awnser
        
    }


    public void OnValueChanged(float value)
    {
        
        soundFXLevel = value;
    }
    
}









