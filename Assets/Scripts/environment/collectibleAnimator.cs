using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectibleAnimator : MonoBehaviour
{
    //adjust this to change speed
    float speed = 5f;
    //adjust this to change how high it goes
    float height = 0.5f;
    void Update() {
        Vector3 pos = transform.localPosition;
        //calculate what the new Y position will be
        float newY = Mathf.Sin(Time.time * speed);
        //set the object's Y to the new calculated Y
        transform.localPosition = new Vector3(pos.x, newY, pos.z) * height;
    }
}
