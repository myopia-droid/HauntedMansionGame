using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class testScript : MonoBehaviour
{

  public GameObject boss1;
  public GameObject oldPrefab;
    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine(perish());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator perish() {
     yield return new WaitForSeconds(30); //waits 15 seconds
     //GameObject.Find("boss2").SetActive(true);
     Instantiate (boss1, this.transform.position, Quaternion.Euler(0, 180, 0));
     Destroy(oldPrefab);
    }
}
