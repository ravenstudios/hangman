using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMainMusicFromTimeStamp : MonoBehaviour
{
    [SerializeField] AudioSource mainTheme;
    [SerializeField] float timeStamp;

    private void Awake()
    {
        timeStamp = MusicTimestamp.GetTimeStamp();

        mainTheme.time = timeStamp;
        mainTheme.PlayScheduled(timeStamp);
    }
    
}
