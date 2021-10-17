using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guess : MonoBehaviour
{
    [SerializeField] int numberOfgusses;
    List<GameObject> letterObjects = new List<GameObject>();
    string word;

    [SerializeField] AudioSource mainMusic;
    [SerializeField] AudioSource rightAwnserSound;
    [SerializeField] AudioSource wrongAwnserSound;
    [SerializeField] AudioSource wonSound;
    [SerializeField] AudioSource lostSound;

    [SerializeField] GameObject resultArea;

    [SerializeField] int guessesLeft;


    void Start()
    {

        //word = Component<GameObject>("dft").GetWord();
        var resultAreaScript = resultArea.GetComponent<ShowWord>();
        word = resultAreaScript.GetWord();
        letterObjects = resultAreaScript.GetLetters();
    }

    void Update()
    {
        
    }

    public void GuessLetter(char letter)
    {
        for (int i = 0; i < letterObjects.Count; i++)
        {
            char l = letterObjects[i].GetComponent<ShowLetter>().GetChar();

            if (l == letter)
            {
                letterObjects[i].GetComponent<ShowLetter>().Show(letter);

                rightAwnserSound.Play();
                numberOfgusses++;

                if (numberOfgusses == word.Length)
                {
                    wonSound.Play();
                    return;
                }

                //return;

            }
        }

        WrongGuess();



        if (guessesLeft == 0)
        {
            mainMusic.Stop();
            wonSound.Play();
            return;
        }

    }


    void WrongGuess()
    {
        guessesLeft--;
        //health.GetComponent<Health>().Show(guessesLeft);
        wrongAwnserSound.Play();

    }
}
