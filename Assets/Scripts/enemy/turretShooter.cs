using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretShooter : MonoBehaviour
{
  private float timeBtwnShots;
  public float startTimeBtwnShots;

  public GameObject projectile;
  public Transform shotPoint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      //if turret is not on cooldown, shoot, else decrease cooldown
      if (timeBtwnShots <= 0) {
        Instantiate(projectile, shotPoint.position, transform.rotation);
        timeBtwnShots = startTimeBtwnShots;
      } else {
        timeBtwnShots -= Time.deltaTime;
      }
    }
}
