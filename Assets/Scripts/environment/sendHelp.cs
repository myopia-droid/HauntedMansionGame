using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sendHelp : MonoBehaviour
{
  public Canvas canvas;
  public GameObject boss;

  void Start() {
    canvas.enabled = false;
  }
  void Update() {
    if (GameObject.Find("Boss") == null) {
      canvas.enabled = true;
    }
  }
}
