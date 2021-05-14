using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jumpToLevelSelect : MonoBehaviour
{
  public bool inLevelSelect;
  void Update() {
    if (inLevelSelect == false && Input.GetKeyDown("backspace")) {
      SceneManager.LoadScene("LevelSelect", LoadSceneMode.Additive);
      inLevelSelect = true;
    } else if (inLevelSelect == true && Input.GetKeyDown("backspace")){
      SceneManager.UnloadScene("LevelSelect");
      inLevelSelect = false;
    }
  }
}
