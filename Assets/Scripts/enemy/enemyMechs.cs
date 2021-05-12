using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyMechs : MonoBehaviour {
  public int health;
  public Slider healthBar;
  public int damage;

  public GameObject deathFX;
  public bool isBoss;
  public GameObject door;
  public GameObject collectible;
  public GameObject player;

  public GameObject heart;
  const float dropChance = 3f / 5f;

  //adjust this to change speed
  float speed = 5f;
  //adjust this to change how high it goes
  float height = 0.5f;

//main script that sets enemy values like HP and how much damage it can deal per hit
    void Update() {
      healthBar.value = health;
      if (health <= 0) {
        Instantiate(deathFX, transform.position, Quaternion.identity);
        if(Random.Range(0f, 1f) <= dropChance) {
          Instantiate(heart, transform.position, Quaternion.identity); //drops heart
        }
        Destroy(gameObject);
        if (isBoss == true) {
          Instantiate(door, new Vector3(player.transform.position.x, -0.77f, 0), Quaternion.identity);
          Instantiate(collectible, new Vector3(transform.position.x + 0.77f, transform.position.y, 0), Quaternion.identity);
        }
      }
    }
}
