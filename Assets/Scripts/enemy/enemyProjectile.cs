using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyProjectile : MonoBehaviour
{
  public int damage;
  public bool facingRight;
  public float speed;
  public float duration;

  private bool playerInvul = false;
  private int orientation;

  public GameObject destroyMagic;

  private void Start() {
    if (facingRight == true) {
      orientation = 1;
    } else {
      orientation = -1;
    }
    Invoke("destroyProjectile", duration);
  }

  void OnTriggerEnter2D(Collider2D col){
    if (playerInvul == false) {
      if (col.gameObject.tag == "Player") {
        col.GetComponent<playerController>().takeDamage(damage);
        var player = col.GetComponent<playerController>();
        player.knockbackCount = player.knockbackLength;

        if(col.transform.position.x < transform.position.x) {
          player.knockFromRight = true;
        } else {
          player.knockFromRight = false;
        }
        StartCoroutine(invul());
      }
    }
    Debug.Log("Other Collider:" + col.name);
    destroyProjectile();
  }

  IEnumerator invul() {
     playerInvul = true;
     yield return new WaitForSeconds(0.5f);
     playerInvul = false;
  }

  void Update() {
    transform.Translate(orientation * transform.right * speed * Time.deltaTime);
  }

  void destroyProjectile() {
    Instantiate(destroyMagic, transform.position, Quaternion.identity);
    Destroy(gameObject);
  }
}
