using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightToggler : MonoBehaviour
{
    // making these public will show them in the inspector (set the values there)
    public float delay; // amount of time before toggling
    public float minIntensity; // the minimum intensity of the light
    public float maxIntensity; // the maximum intensity of the light
    public bool startAtMin;
 
    // variable to hold a reference to the Light component on this gameObject
    private Light myLight;
 
    // variable to hold the amount of time that has passed
    private float timeElapsed;
 
    // this function is called once by Unity the moment the game starts
    private void Awake()
    {
        // get a reference to the Light component
        myLight = GetComponent<Light>();
 
        // if the GetComponent was successful, the variable will no longer be empty (null)
        if(myLight != null)
        {
            // if startAtMin is true, set intensity to the min to start, otherwise set to max
            myLight.intensity = startAtMin ? minIntensity : maxIntensity;
        }
    }
 
    // this function is called every frame by Unity
    private void Update()
    {
        // if we have a reference to the Light component
        if(myLight != null)
        {
            // add the amount of time that has passed since last frame
            timeElapsed += Time.deltaTime;
 
            // if the amount of time passed is greater than or equal to the delay
            if(timeElapsed >= delay)
            {
                // reset the time elapsed
                timeElapsed = 0;
                // toggle the light
                ToggleLight();
            }
        }
    }
 
    // function to toggle between two intensities
    public void ToggleLight()
    {
        // if the variable is not empty
        if(myLight != null)
        {
            // if the intensity is currently the minimum, switch to max
            if(myLight.intensity == minIntensity)
            {
                myLight.intensity = maxIntensity;
            }
            // if the intensity is currently the max, switch to min
            else if(myLight.intensity == maxIntensity)
            {
                myLight.intensity = minIntensity;
            }
        }
    }
}
