using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTimestamp : MonoBehaviour
{
    static float timeStamp;

    public static float GetTimeStamp()
    {
        return timeStamp;
    }

    public static void SetTimeStamp(float t)
    {
        timeStamp = t;
    }
}
