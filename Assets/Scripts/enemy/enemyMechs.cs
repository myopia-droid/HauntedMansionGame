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
  public GameObject player;

//main script that sets enemy values like HP and how much damage it can deal per hit
    void Update() {
      healthBar.value = health;
      if (health <= 0) {
        Instantiate(deathFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
        if (isBoss == true) {
          Instantiate(door, new Vector3(player.transform.position.x, -0.77f, 0), Quaternion.identity);
        }
      }
    }
}
