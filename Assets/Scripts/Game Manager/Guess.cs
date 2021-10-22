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

    [SerializeField] GameObject letterObject;
    [SerializeField] GameObject keyboard;
    [SerializeField] int guessesLeft;

     

    public void GuessLetter(char letter)
    {
        bool didGuessRight = false;
        word = letterObject.GetComponent<ShowWord>().GetWord();
        letterObjects = letterObject.GetComponent<ShowWord>().GetLetters();

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

                    Rigidbody2D[] letterRbs = keyboard.GetComponentsInChildren<Rigidbody2D>();

                    foreach (var letRB in letterRbs)
                    {
                        letRB.isKinematic = false;
                        
                        float x = Random.Range(-10.0f, 10.0f);
                        letRB.AddForce(new Vector2(x, 10), ForceMode2D.Impulse);
                    }
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
            Rigidbody2D[] letterRbs = keyboard.GetComponentsInChildren<Rigidbody2D>();

            foreach (var letRB in letterRbs)
            {
                letRB.isKinematic = false;

            
            }

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
