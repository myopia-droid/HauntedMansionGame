using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upAndDown : MonoBehaviour
{
  int direction = 1; //int direction where 0 is stay, 1 up, -1 down    
    public int top;
    public int bottom;

    public float speed;


	void Update () 
    {
        if (transform.position.y >= top)
            direction = -1;

        if (transform.position.y <= bottom)
            direction = 1;

        transform.Translate(0, speed * direction * Time.deltaTime, 0);
	}
}

