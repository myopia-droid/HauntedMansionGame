using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyecollect : MonoBehaviour
{
   public GameObject eye;
    
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player"))
        {
          
          Destroy(eye);       
        }
}
}
