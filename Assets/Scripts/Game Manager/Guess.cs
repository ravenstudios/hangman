using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guess : MonoBehaviour
{
    [SerializeField] int numberOfgusses;
    List<GameObject> letterObjects = new List<GameObject>();
    [SerializeField]  string word;

    [SerializeField] AudioSource mainMusic;
    [SerializeField] AudioSource rightAwnserSound;
    [SerializeField] AudioSource wrongAwnserSound;
    [SerializeField] AudioSource wonSound;
    [SerializeField] AudioSource lostSound;

    [SerializeField] GameObject resultArea;

    [SerializeField] int guessesLeft;

     

    public void GuessLetter(char letter)
    {
        bool didGuessRight = false;
        word = resultArea.GetComponent<ShowWord>().GetWord();
        letterObjects = resultArea.GetComponent<ShowWord>().GetLetters();

        for (int i = 0; i < letterObjects.Count; i++)
        {
            char l = letterObjects[i].GetComponent<ShowLetter>().GetChar();

            if (l == letter)
            {
                letterObjects[i].GetComponent<ShowLetter>().Show(letter);

                rightAwnserSound.Play();
                numberOfgusses++;
                didGuessRight = true;


                if (numberOfgusses == word.Length)
                {
                    Debug.Log("word lentgth: " + word.Length + "   numOgGusses: " + numberOfgusses);
                    mainMusic.Stop();
                    wonSound.Play();
                    return;
                }

                //return;

            }
        }

        if (!didGuessRight)
        {
            WrongGuess();
        }
        



        if (guessesLeft == 0)
        {
            mainMusic.Stop();
            lostSound.Play();
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
