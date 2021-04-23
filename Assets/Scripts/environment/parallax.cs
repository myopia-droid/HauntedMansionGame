using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour {
  private float length, startpos;
  public GameObject cam;
  public float parallaxValue;

    void Start() {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate() {
        float temp = (cam.transform.position.x * (1-parallaxValue));
        float distance = (cam.transform.position.x * parallaxValue);
        transform.position = new Vector3(startpos + distance, transform.position.y, transform.position.z);
        if (temp > startpos + length) {
          startpos += length;
        } else if (temp < startpos - length) {
          startpos -= length;
        }
    }
}
