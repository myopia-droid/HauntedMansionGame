using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightFlicker : MonoBehaviour
{
    public Light gearLight;
    public Light candleA;
    public Light candleB;
    public Light lantern;
    public float timer;

    public bool lightsOn = true;
    public Color darknessColour;
    public Color brightColour;

    // Start is called before the first frame update
    void Start()
    {
        timer = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (lightsOn) //if lights are on
        {
            if (timer <= 0.0) //if the timer has ended
            {
                turnOffLights(); //turn lights off
                timer = 1.0f;    //for half a second
                lightsOn = false;
            }
            else
            {
                timer -= Time.deltaTime;
            }

        } else //if lights are off
        {

            if (timer <= 0.0) //if the timer has ended
            {
                turnOnLights(); //turn lights on
                timer = 10.0f;  //for ten seconds
                lightsOn = true;
            }
            else
            {
                timer -= Time.deltaTime;
            }

        }

    }

    void turnOffLights()
    {
        if (gearLight != null) {
            gearLight.intensity = 0;
        }
        candleA.intensity = 0;
        candleB.intensity = 0;
        lantern.intensity = 0;
        RenderSettings.ambientLight = darknessColour;
    }

    void turnOnLights()
    {
        if (gearLight != null)
        {
            gearLight.intensity = 2;
        }
        candleA.intensity = 5;
        candleB.intensity = 5;
        if (lantern != null)
        {
            lantern.intensity = 4;
        }
        RenderSettings.ambientLight = brightColour;
    }
}
