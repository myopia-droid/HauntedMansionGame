using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class keyCount : MonoBehaviour
{
   public double key =1;

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.ChangeScore(key);
            
        }
    }
}
