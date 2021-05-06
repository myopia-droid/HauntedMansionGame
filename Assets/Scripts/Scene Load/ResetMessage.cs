using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetMessage : MonoBehaviour
{
    public Text showpresse;
    // Start is called before the first frame update
    void Start()
    {
        showpresse.GetComponent<Renderer>().enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
