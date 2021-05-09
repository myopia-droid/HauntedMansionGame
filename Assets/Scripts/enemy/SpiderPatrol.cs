using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderPatrol : MonoBehaviour
{
    public float RotateSpeed = 5f;
    public float RadiusChangeSpeed = 0.1f;
    public float TargetRadius = 0.3f;
    private Vector2 centre;
    private float angle;
    private float actualRadius;
   
    private void Start()
    {
        centre = transform.position;
        actualRadius = TargetRadius = 0.3f;
    }
 
    private void Update()
    {
        if (Input.GetKeyDown (KeyCode.DownArrow)) {
            TargetRadius = 1f;
        }
        if (actualRadius == TargetRadius) {
        angle += RotateSpeed * Time.deltaTime;
}
        actualRadius = Mathf.MoveTowards(actualRadius, TargetRadius, RadiusChangeSpeed * Time.deltaTime);
        var offset = new Vector2 (Mathf.Sin (angle), Mathf.Cos (angle)) * actualRadius;
        transform.position = centre + offset;
    }
}
