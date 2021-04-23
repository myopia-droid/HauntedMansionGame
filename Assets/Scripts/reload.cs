using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reload : MonoBehaviour
{
  void Update() {
    if (Input.GetKeyDown(KeyCode.R)) {
      SceneManager.LoadScene("Main scene");
    }
  }
}
