using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {
  public Transform playerController;

  public bool bounds;

  public Vector3 minCameraPos;
  public Vector3 maxCameraPos;

    public void FixedUpdate() {
      if (playerController != null) {
        transform.position = new Vector3 (playerController.position.x, transform.position.y, transform.position.z);
      }
      if (bounds == true) {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minCameraPos.x, maxCameraPos.x), transform.position.y, transform.position.z);
      }
    }
}
