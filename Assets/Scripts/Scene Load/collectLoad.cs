using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collectLoad : MonoBehaviour
{
  public string areaToLoad;
  public playerController player;
  public float collectiblesPerStage;

    void Start() {
      player = GameObject.FindGameObjectWithTag("Player").GetComponent<playerController>();
    }

    void OnTriggerEnter2D (Collider2D other) {
          if (other.tag == "Player") {
            if (player.collectibleExists == true && player.collectibleCount >= collectiblesPerStage) {
             SceneManager.LoadScene(areaToLoad);
      }
          }
    }
     

    
}
