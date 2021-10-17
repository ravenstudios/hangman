using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class PanelHideComponets : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject keys;
    [SerializeField] GameObject result;


    public void ShowPanel()
    {
        panel.SetActive(true);
        keys.SetActive(false);
        result.SetActive(false);
    }

    public void HidePanel()
    {
        panel.SetActive(false);
        keys.SetActive(true); ;
        result.SetActive(true);
    }
}
