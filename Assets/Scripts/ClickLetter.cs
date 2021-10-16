using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickLetter : MonoBehaviour
{
    GameObject gameManager;

    [SerializeField] char c;
    [SerializeField] float fallDelay;
    Rigidbody2D rb;
    BoxCollider2D bc;

    void Awake()
    {
        
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();



        gameManager = GameObject.Find("GameManager");
    }

    public void SetChar(char chr)
    {
        c = chr;
    }


    public char GetChar()
    {
        return c;
    }


    void OnMouseDown()
    {

        gameManager.GetComponent<GameManager>().Guess(c);
        
        rb.isKinematic = false;
        bc.enabled = false;
        float x = Random.Range(-10.0f, 10.0f);
        rb.AddForce(new Vector2(x, 10), ForceMode2D.Impulse);
        //StartCoroutine(DelayAction(fallDelay));
        
        
    }


    IEnumerator DelayAction(float delayTime)
    {
        //Wait for the specified delay time before continuing.
        yield return new WaitForSeconds(delayTime);

        //Do the action after the delay time has finished.
        bc.enabled = false;
    }
}

