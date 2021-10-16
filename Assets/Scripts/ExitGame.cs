using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void exit()
    {
        Debug.Log("exit called");
        Application.Quit();
    }
}
