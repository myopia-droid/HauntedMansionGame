using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpChase : MonoBehaviour
{
    public float timer;
    public float minTime;
    public float maxTime;
    public float speed;

    private Transform playerPos;
    private bool isTouchingPlayer;

    public void Start() {
      playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
      timer = Random.Range(minTime, maxTime);
    }

    public void Update() {
      float step = speed * Time.deltaTime;
      Vector2 target = new Vector2(playerPos.position.x, transform.position.y); //add animator later

      if (isTouchingPlayer == false) {
        transform.position = Vector2.MoveTowards(transform.position, target, step);
      }
      //lookAt();
    }

    void OnCollisionStay2D(Collision2D collision) {
        if (collision.gameObject.tag == "Player") {
          isTouchingPlayer = true;
        } else {
          isTouchingPlayer = false;
        }
    }
}
