using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stageTransition : MonoBehaviour {
  public string areaToLoad;
  private bool doorEntered;

  void OnTriggerEnter2D (Collider2D other) {
        if (other.tag == "Player") {
          Debug.Log("door");
          doorEntered = true;
        }
    }

    void OnTriggerExit2D() {
      doorEntered = false;
    }

    void Update() {
      if (Input.GetKeyDown(KeyCode.UpArrow) && doorEntered == true) {
        SceneManager.LoadScene(areaToLoad);
      }
    }
}
