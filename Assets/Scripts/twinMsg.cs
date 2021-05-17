using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class twinMsg : MonoBehaviour
{
   public Text msg;
    // Start is called before the first frame update
    void Start()
    {
        msg.GetComponent<Renderer>().enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
