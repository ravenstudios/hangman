using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameButton : MonoBehaviour
{
    [SerializeField] GameObject keyboard;
    [SerializeField] GameObject endOfGamePanle;
    [SerializeField] AudioSource mainGameSound;
    [SerializeField] GameObject lettersObj;
    


    public void  NewGameButn ()
    {
        keyboard.GetComponent<Keyboard>().MakeKeyboard();
        endOfGamePanle.SetActive(false);
        mainGameSound.Play();
        lettersObj.GetComponent<ShowWord>().SetUpGame();
    }
}
