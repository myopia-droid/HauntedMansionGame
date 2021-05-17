using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossHead : MonoBehaviour
{
   // public GameObject head1;
   // public GameObject head2;
    //private float timer;
    public GameObject Boss1;
    public GameObject oldPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(perish());
    }


    IEnumerator perish() {
     yield return new WaitForSeconds(30); //waits 15 seconds
     Destroy(oldPrefab);
     //GameObject.Find("boss2").SetActive(true);
     Instantiate(Boss1, transform.position, Quaternion.identity);    
    }
}
// Update is called once per frame
    /*void Update()
    {

     if(this.timer > 10.0f){
         Instantiate(myPrefab, new Vector3(transform.position.x, -180f, 0), Quaternion.identity);
        //GameObject.Find("boss").SetActive(false);
       // GameObject.Find("boss2").SetActive(true);
        //Debug.Log();
     }
     public GameObject deathFX;*/
    // Start is called before the first frame update
