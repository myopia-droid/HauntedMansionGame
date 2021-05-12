using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LeadToBoss2 : MonoBehaviour
{
    public Text showpresse;
    public GameObject door;
    //public GameObject girl;

    void start()
    {
        //light.GetComponent<Light>().intensity=0; 

    }

    void OnTriggerStay2D(Collider2D other){
        if(door.GetComponent<Renderer>().enabled==true)
        {
        if(other.CompareTag("Player"))
        {
            //light.GetComponent<Light>().intensity=10; 
            showpresse.enabled=true;
            showpresse.text= "Press [W] to next stage!";
            if(Input.GetKeyDown("w")||Input.GetKeyDown("w")){
                SceneManager.LoadScene("EndofPlatform2");
            }
            
        }
        }
    }

    void OnTriggerExit2D(Collider2D other){
        showpresse.enabled=false;
    }
}
