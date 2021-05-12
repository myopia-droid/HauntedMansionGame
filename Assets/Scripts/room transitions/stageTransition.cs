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
      Debug.Log("door unentered" + doorEntered);
    }

    void Update() {
      if (Input.GetKeyDown(KeyCode.UpArrow) && doorEntered == true || Input.GetKeyDown(KeyCode.W) && doorEntered == true) {
        SceneManager.LoadScene(areaToLoad);
      }
    }
}
