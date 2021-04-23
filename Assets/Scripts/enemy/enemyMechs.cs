using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyMechs : MonoBehaviour {
  public int health;
  public Slider healthBar;
  public int damage;

  public GameObject deathFX;

//main script that sets enemy values like HP and how much damage it can deal per hit
    void Update() {
      healthBar.value = health;
      if (health <= 0) {
        Instantiate(deathFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
      }
    }
}
