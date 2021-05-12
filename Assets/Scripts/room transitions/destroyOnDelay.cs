using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnDelay : MonoBehaviour
{
    public GameObject deathFX;
    // Start is called before the first frame update
    void Start() {
      StartCoroutine(perish());
    }

    IEnumerator perish() {
     yield return new WaitForSeconds(3); //waits 3 seconds
     Destroy(gameObject);
     Instantiate(deathFX, transform.position, Quaternion.identity);
   }
}
