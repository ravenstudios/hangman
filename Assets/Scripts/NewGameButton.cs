using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameButton : MonoBehaviour
{
    [SerializeField] GameObject keyboard;
    [SerializeField] GameObject endOfGamePanle;
    [SerializeField] AudioSource mainGameSound;
    [SerializeField] GameObject lettersObj;
    [SerializeField] GameObject guessScript;
    


    public void  NewGame()
    {
        
        endOfGamePanle.SetActive(false);
        mainGameSound.Play();
        lettersObj.GetComponent<ShowWord>().SetUpGame();
        guessScript.GetComponent<Guess>().NewGame();
        //reset poitions and guess count


    }
}
