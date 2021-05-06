using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetYoungGirl : MonoBehaviour
{
    public GameObject girl;
    
    // Start is called before the first frame update
    void Start()
    {
         girl.GetComponent<Renderer>().enabled=false;
         
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
