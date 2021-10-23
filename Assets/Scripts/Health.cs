using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] GameObject prefab;
    [SerializeField] GameObject GuessScript;
    [SerializeField] Transform parentPos;
    List<GameObject> potions = new List<GameObject>();
    

    private void Start()
    {
        int guesses = GuessScript.GetComponent<Guess>().GetGuesses();
        Show(guesses);
    }

    

    public void Show(int num)
    {
        potions.ForEach(delegate (GameObject potion) {
            Destroy(potion);
        });


        for (int i = 0; i < num; i++)
        {
            Vector3 pos = new Vector3(i, 0, 0) + parentPos.position;
            potions.Add(Instantiate(prefab, pos, Quaternion.identity));
        }
        
    }
}
