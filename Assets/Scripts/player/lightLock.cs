using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightLock : MonoBehaviour
{
  public playerController player;
    // Start is called before the first frame update
    void Start()
    {
      player = GameObject.FindGameObjectWithTag("Player").GetComponent<playerController>();
    }

    // Update is called once per frame
    void Update()
    {
      if (player.facingRight == false) {
        transform.position = new Vector3(transform.position.x, transform.position.y, -1f);
      }
    }
}
