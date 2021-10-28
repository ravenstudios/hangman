using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangMusicWhenPaused : MonoBehaviour
{
   
   
    [SerializeField] AudioSource main;
    [SerializeField] AudioSource mainRadio;
    [SerializeField] Button menuButton;
    [SerializeField] Button backButton;

   float timeStamp;


    private void Awake()
    {
       
        menuButton.onClick.AddListener(GameToPaused);
        backButton.onClick.AddListener(PausedToGame);
    }

    private void GameToPaused()
    {
        // MusicTimestamp.SetTimeStamp(main.time);
        
       
        mainRadio.time = main.time;
        mainRadio.Play();

        main.Stop();
    }

    private void PausedToGame()
    {
        // MusicTimestamp.SetTimeStamp(main.time);
        
        
        main.time = mainRadio.time;
        main.Play();

        mainRadio.Stop();
    }
}
