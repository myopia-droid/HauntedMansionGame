using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerOnPlatform : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name.Equals ("platform (3)"))
        {
            this.transform.parent = col.transform;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if(col.gameObject.name.Equals ("platform (3)"))
        this.transform.parent = null;
    }
}
