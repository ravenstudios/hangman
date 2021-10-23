using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class PulsingLight : MonoBehaviour
{

    [SerializeField] Light2D myLight;
    [SerializeField]  float min, max, speed;
    

    //private Light myLight;
    //public float maxIntensity = 1f;
    //public float minIntensity = 0f;
    //public float pulseSpeed = 1f; //here, a value of 0.5f would take 2 seconds and a value of 2f would take half a second
    private float targetIntensity = 1f;
    private float currentIntensity;
    // Start is called before the first frame update
    void Start()
    {
        //l.intensity = 7;
    }

    // Update is called once per frame
    void Update()
    {

        currentIntensity = Mathf.MoveTowards(myLight.intensity, targetIntensity, Time.deltaTime * speed);
        if (currentIntensity >= max)
        {
            currentIntensity = max;
            targetIntensity = min;
        }
        else if (currentIntensity <= min)
        {
            currentIntensity = min;
            targetIntensity = max;
        }
        myLight.intensity = currentIntensity;
    }

  

    
}
