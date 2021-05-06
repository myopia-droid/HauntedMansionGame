using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    public GameObject light;
    
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player"))
        {
          light.GetComponent<Light>().intensity=0;         
        }
    }
}
