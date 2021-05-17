using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GirlControler : MonoBehaviour
{
    public GameObject girl;
    public GameObject door;
    public GameObject light;
    public Text showpresse;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerStay2D(Collider2D other){
        if(girl.GetComponent<Renderer>().enabled==true)
        {
        if(other.CompareTag("Player"))
        {
            showpresse.enabled=true;
            showpresse.text= "Press [w] or [↑] to give her the cloths";
            //light.GetComponent<Light>().intensity=10; 
            if(Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow)){
                SceneManager.LoadScene("EndofPlatform2");
            }

        }
        }
    }

    void OnTriggerExit2D(Collider2D other){
        showpresse.enabled=false;
    }
}
