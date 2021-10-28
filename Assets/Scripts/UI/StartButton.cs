using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

using UnityEngine.SceneManagement;
public class StartButton : MonoBehaviour
{
    [SerializeField] AudioSource main;

    public void OnClick()
    {
        float t = main.time;
        MusicTimestamp.SetTimeStamp(t);
        SceneManager.LoadScene("Gameplay");
    }
}
