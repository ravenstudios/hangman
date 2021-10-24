using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guess : MonoBehaviour
{
    [SerializeField] int numberOfGusses;
    List<GameObject> letterObjects = new List<GameObject>();
    [SerializeField]  string word;

    [SerializeField] AudioSource mainMusic;
    [SerializeField] AudioSource rightAwnserSound;
    [SerializeField] AudioSource wrongAwnserSound;
    [SerializeField] AudioSource wonSound;
    [SerializeField] AudioSource lostSound;

    [SerializeField] GameObject letterObject;
    [SerializeField] GameObject keyboard;
    [SerializeField] GameObject EndGamePanel;
    [SerializeField] GameObject health;
    [SerializeField] int guessesLeft;
    bool didGuessRight;



    public void GuessLetter(char letter)
    {
        didGuessRight = false;
        word = letterObject.GetComponent<ShowWord>().GetWord();
        letterObjects = letterObject.GetComponent<ShowWord>().GetLetters();

        for (int i = 0; i < letterObjects.Count; i++)
        {
            char l = letterObjects[i].GetComponent<ShowLetter>().GetChar();

            if (l == letter)
            {
                RightGuess(letterObjects[i], letter);

            }

            if (numberOfGusses == word.Length)
            {
                WonGame();

                    
                return;
            }

            //return;

            
        }

        if (!didGuessRight)
        {
            WrongGuess();
        }
        



        if (guessesLeft == 0)
        {
            LostGame();
            return;
        }

    }


    void WrongGuess()
    {
        guessesLeft--;
        health.GetComponent<Health>().Show(guessesLeft);
        wrongAwnserSound.Play();

    }

    void RightGuess(GameObject obj, char letter)
    {
        obj.GetComponent<ShowLetter>().Show(letter);

        rightAwnserSound.Play();
        numberOfGusses++;
        didGuessRight = true;
    }


    void WonGame()
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
        EndGamePanel.SetActive(true);

    }


    void LostGame()
    {

        //******* Show word after loss********

        letterObjects.ForEach(delegate(GameObject letterObj)
        {
            char l = letterObj.GetComponent<ShowLetter>().GetChar();
            letterObj.GetComponent<ShowLetter>().Show(l);
        });

        Rigidbody2D[] letterRbs = keyboard.GetComponentsInChildren<Rigidbody2D>();

        foreach (var letRB in letterRbs)
        {
            letRB.isKinematic = false;


        }

        mainMusic.Stop();
        lostSound.Play();
        EndGamePanel.SetActive(true);
        
    }


    public void NewGame()
    {
        
        numberOfGusses = 0;
        guessesLeft = 6;
        keyboard.GetComponent<Keyboard>().MakeKeyboard();
        health.GetComponent<Health>().Show(guessesLeft);
    }

    public int GetGuesses()
    {
        return guessesLeft;
        
    }

    public void SetGuesses(int g)
    {
        guessesLeft = g;
    }

}
