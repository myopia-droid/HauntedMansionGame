using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LeadToBoss2 : MonoBehaviour
{
    public Text showpresse;
    public GameObject door;

    void OnTriggerStay2D(Collider2D other){
        //if(door.GetComponent<Renderer>().enabled)
        //{
        if(other.CompareTag("Player"))
        {
            showpresse.enabled=true;
            showpresse.text= "Press [E] to Boss Room!";
            if(Input.GetKeyDown("e")){
                SceneManager.LoadScene("Boss room 1");
            }
            
        }
       // }
    }

    void OnTriggerExit2D(Collider2D other){
        showpresse.enabled=false;
    }
}
