using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour {
  public GameObject projectile;
  public Transform shotPoint;

  public playerController pc;

  private float timeBtwnShots;
  public float startTimeBtwnShots;

    private void Update() {
      if (pc.facingRight == false) {
        transform.rotation = Quaternion.Euler(0,180,0);
      } else {
        transform.rotation = Quaternion.identity;
      }

      //if weapon use is not on cooldown, shoot, else decrease cooldown
      if (timeBtwnShots <= 0) {
        if (Input.GetKeyDown("space")) {
          Instantiate(projectile, shotPoint.position, transform.rotation);
          timeBtwnShots = startTimeBtwnShots;
        }
      } else {
        timeBtwnShots -= Time.deltaTime;
      }

    }
}
