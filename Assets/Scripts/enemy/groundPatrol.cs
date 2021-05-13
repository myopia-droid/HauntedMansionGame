using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundPatrol : MonoBehaviour
{
  public float speed;
  private bool movingRight = true;

  void Start() {
    movingRight = true;
  }

  void OnTriggerEnter2D(Collider2D other) {
    if (other.gameObject.CompareTag("walls")) {
      movingRight = !movingRight;
    }
  }

  void Update() {
    if (movingRight == true) {
      transform.eulerAngles = new Vector3(0, -180, 0);
    } else {
      transform.eulerAngles = new Vector3(0, 0, 0);
    }
    transform.Translate(Vector2.right * speed * Time.deltaTime);
  }
}
