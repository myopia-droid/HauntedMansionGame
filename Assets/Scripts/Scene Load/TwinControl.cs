using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TwinControl : MonoBehaviour
{
    public GameObject twins;
    public Text msg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerStay2D(Collider2D other){
        if(twins.GetComponent<Renderer>().enabled==true)
        {
        if(other.CompareTag("Player"))
        {
            msg.enabled=true;
            msg.text= "Press [w] or [↑] to give her the eye";
            if(Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow)){
                SceneManager.LoadScene("Level4Outro");
            }
            
        }
        }
}
}
