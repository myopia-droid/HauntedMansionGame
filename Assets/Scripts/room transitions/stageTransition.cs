using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stageTransition : MonoBehaviour {
  public string areaToLoad;
  private bool doorEntered;
  public playerController player;
  public float collectiblesPerStage;

    void Start() {
      player = GameObject.FindGameObjectWithTag("Player").GetComponent<playerController>();
    }

    void OnTriggerEnter2D (Collider2D other) {
          if (other.tag == "Player") {
            if (player.collectibleExists == true && player.collectibleCount >= collectiblesPerStage) {
              doorEntered = true;
            } else if (player.collectibleExists == false) {
              doorEntered = true;
            }
            Debug.Log("door");
          }
      }

      void OnTriggerExit2D() {
        doorEntered = false;
        Debug.Log("door unentered" + doorEntered);
      }

      void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow) && doorEntered == true || Input.GetKeyDown(KeyCode.W) && doorEntered == true) {
          SceneManager.LoadScene(areaToLoad);
        }
      }
}
