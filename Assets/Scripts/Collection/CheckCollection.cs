using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckCollection : MonoBehaviour
{
    public GameObject girl;
    //public GameObject light;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ScoreManager.instance.getscore()>=3)
        {
            girl.GetComponent<Renderer>().enabled=true;
            //light.GetComponent<Light>().intensity=5;
        }
    }
}
