using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyeControl : MonoBehaviour
{
     public playerController player;
     public float collectiblesPerStage;
     public GameObject twins;

    void Start() {
      player = GameObject.FindGameObjectWithTag("Player").GetComponent<playerController>();
    }

    void OnTriggerEnter2D (Collider2D other) {
          if (other.tag == "Player") {
            if (player.collectibleExists == true && player.collectibleCount >= collectiblesPerStage) {
             twins.GetComponent<Renderer>().enabled=true;
      }
          }
    }
}
